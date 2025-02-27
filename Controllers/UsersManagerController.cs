using Microsoft.AspNetCore.Mvc;

namespace UsersManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersManagerController : ControllerBase
    {
        private readonly UsersManager usersManager = new UsersManager();

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return usersManager.GetUsers();
        }

        [HttpPost(Name = "AddUser")]
        public void Add(User user)
        {
            usersManager.AddUser(user);
        }

        [HttpPut(Name = "UpdateUser")]
        public void Update(User user)
        {
            usersManager.UpdateUser(user);
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete(User user)
        {
            usersManager.DeleteUser(user);
        }
    }
}
