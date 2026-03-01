using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WBF_Tuan_1.Models
{
	[Table("Users")]
	public class User
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Username { get; set; } = "";
		public string Password { get; set; } = "";
		public string EmailAdress { get; set; } = "";
		public string PhoneNumber { get; set; } = "";

	}
}
