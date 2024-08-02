using EmrysSerenShared;

namespace EmrysSerenAPI.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userid);
        User GetUserByEmail(string useremail);

    }
}
