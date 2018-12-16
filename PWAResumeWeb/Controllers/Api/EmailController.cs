using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PWABusinessProcess;
using PWAModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PWAResumeWeb.Controllers.Api
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        // POST api/values
        [HttpPost]
        public async Task PostAsync([FromBody]EmailVM emailVM)
        {
            try
            {
                await EmailServices.SendMail(emailVM);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
