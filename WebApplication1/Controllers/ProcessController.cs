using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [HttpGet]
        public Sonuc Get123(Girdi girdi) {

            ProcessManager _processManager = new ProcessManager();
            Sonuc son1 = _processManager.StartProcess(girdi);

            return son1;        
        }
    }
}
