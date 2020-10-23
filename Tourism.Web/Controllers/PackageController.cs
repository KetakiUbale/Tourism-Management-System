using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Service.Interface;

namespace Tourism.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _packageService;
        public PackageController(IPackageService packageService)
        {
            this._packageService = packageService;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {

            return Ok(this._packageService.GetAllUsers());
        }
    }
}
