using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public List<Users> GetAllUsers()
        {
            List<Users> list = new List<Users>();
            list.Add(new Users() { UserId = 1, FirstName = "Bhoomika", LastName = "Sadashiva", EmailId = "b@gmail.com", Password = "1234" });
            list.Add(new Users() { UserId = 2, FirstName = "Bhoomi", LastName = "Sagara", EmailId = "bs@gmail.com", Password = "12345" });
            return list;
        }

        [HttpGet("id:int")]
        public Users GetUser(int id)
        {
            List<Users> list = new List<Users>();
            list.Add(new Users() { UserId = 1, FirstName = "Bhoomika", LastName = "Sadashiva", EmailId = "b@gmail.com", Password = "1234" });
            list.Add(new Users() { UserId = 2, FirstName = "Bhoomi", LastName = "Sagara", EmailId = "bs@gmail.com", Password = "12345" });
            return list.FirstOrDefault(user => user.UserId == id);
        }

        [HttpPut]
        public Users UpdateUserdetails(int id, string fname, string lname)
        {
            var data = new Users()
            {
                UserId = id,
                FirstName = fname,
                LastName = lname
            };
            return data;
        }

        [HttpPost]
        public List<Users> CreateUserDetails(Users userModel)
        {
            List<Users> list = new List<Users>();
            Users st = new Users()
            {
                UserId = userModel.UserId,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                EmailId = userModel.EmailId,
                Password = userModel.Password
            };
            list.Add(st);

            return list;
        }

        [HttpDelete]

        public bool DeleteUser(int id)
        {
            List<Users> list = new List<Users>();
            var result = list.FirstOrDefault(a => a.UserId == id);
            var deleted = list.Remove(result);
            return deleted; //return true if user with id is deleted otherwise false
        }
    }
}
