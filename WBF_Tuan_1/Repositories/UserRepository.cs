using WBF_Tuan_1.Data;
using WBF_Tuan_1.Models;
namespace WBF_Tuan_1.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context = new AppDbContext();
        public void Save(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public bool ExistedByUsername(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }
		public User? FindByUsername(string username)
		{
            return _context.Users.FirstOrDefault(u => u.Username == username);
		}
	}
}
