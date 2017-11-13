using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApiFileUpload.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uploadedFile"></param>
        [HttpPost]
        [Route("upload")]
        public void PostFile(IFormFile uploadedFile)
        {
            //TODO: Save file
        }
    }
}
