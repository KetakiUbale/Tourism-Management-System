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
    public class PackageContentController : ControllerBase
    {
        private readonly IPackageContentService _packagecontentService;
        public PackageContentController(IPackageContentService packagecontentService)
        {
            this._packagecontentService = packagecontentService;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {

            return Ok(this._packagecontentService.GetAllUsers());
        }
    }
}
