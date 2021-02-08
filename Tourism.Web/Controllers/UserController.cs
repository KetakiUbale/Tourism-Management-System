using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Model;
using Tourism.Service;

namespace Tourism.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
      
        
        [HttpGet("getallusers")]
        public IActionResult getallusers()
        {

            return Ok(this._userService.GetAllUsers());
        }
        
        
        [HttpGet("getuserbyemail/{email}")]
        public IActionResult GetUserByEmail(string email)
         {
            return Ok(this._userService.GetByEmail(email));
         }
        
        
        [HttpPost("adduser")]
        public IActionResult AddUser(User user)
        {
            return Ok(this._userService.AddUser(user));
        }
       
        
        [HttpPut("updateuser")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(this._userService.UpdateUser(user));
        }

        [HttpDelete("deleteuser/{userId}")]
        public IActionResult DeleteUser(int userid)
        {
            return Ok(this._userService.DeleteUser(userid));
        }

    }
}
