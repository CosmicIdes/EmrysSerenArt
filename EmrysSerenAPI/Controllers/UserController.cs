using EmrysSerenAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmrysSerenAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userRepository.GetAllUsers());
        }

        [HttpGet("{userid}")]
        public IActionResult GetUserById(int userid)
        {
            return Ok(_userRepository.GetUserById(userid));
        }

        [HttpGet("{useremail}")]
        public IActionResult GetUserByEmail(string useremail)
        {
            return Ok(_userRepository.GetUserByEmail(useremail));
        }
    }
}
