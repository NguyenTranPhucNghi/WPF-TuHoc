using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WBF_Tuan_1.Models;
using WBF_Tuan_1.Repositories;
using WBF_Tuan_1.Views.Home;

namespace WBF_Tuan_1.Views.Onboarding
{
	public partial class LogInNew : Page
	{
		private readonly UserRepository userResponsitory = new();
		public LogInNew()
		{
			InitializeComponent();
		}
		private void btnLogIn_Click(object sender, RoutedEventArgs e)
		{
			string email = txtEmailAdress.Text.Trim();
			string password = txtPassword.Text.Trim();

			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Vui long nhap day du thong tin", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

			User? user = userResponsitory.FindByUsername(email);
			if (user == null||user.Password != password)
			{
				MessageBox.Show("Ten dang nhap hoac mat khau khong dung", "Dang nhap lai", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}

			NavigationService.Navigate(new HomePage());
		}

		private void btnSignUp_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new SignUpNew());
		}
	}
}
