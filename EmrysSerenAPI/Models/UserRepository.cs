using EmrysSerenShared;
using EmrysSerenData;

namespace EmrysSerenAPI.Models
{
    public class UserRepository : IUserRepository    
    {
        private readonly ESDbContext _esDbContext;

        public UserRepository(ESDbContext esDbContext)
        {
            _esDbContext = esDbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _esDbContext.Users;
        }

        public User GetUserById(int UserId)
        {
            return _esDbContext.Users.FirstOrDefault(u => u.UserId == UserId);
        }

        public User GetUserByEmail(string UserEmail)
        {
            return _esDbContext.Users.FirstOrDefault(e => e.UserEmail == UserEmail);
        }
    }
}
