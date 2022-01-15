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
        public Sonuc GetSonuc(int Sayi1,int Sayi2, string islem) {

            ProcessManager _processManager = new ProcessManager();
            Girdi girdi = new Girdi() { Sayi1 = Sayi1, Sayi2 = Sayi2, islem = islem };
            Sonuc son1 = _processManager.StartProcess(girdi);

            return son1;        
        }
    }
}
