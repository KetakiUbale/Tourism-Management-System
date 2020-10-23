using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Service;

namespace Tourism.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userroleService;
        public UserRoleController(IUserRoleService userroleService)
        {
            this._userroleService = userroleService;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {

            return Ok(this._userroleService.GetAllUsers());
        }
    }
}
