using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public DebugController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET: api/Debug
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(new
            {
                ClientId = configuration["AzureAd-ClientId"],
                ClientSecret = configuration["AzureAd-ClientSecret"],
                Domain = configuration["AzureAd-Domain"],
                Instance = configuration["AzureAd-Instance"],
                TenantId = configuration["AzureAd-TenantId"]
            });
        }
    }
}
