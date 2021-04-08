using Hemnet40.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Hej hej
namespace Hemnet40.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //HALLÅ!
    public class HomeController : Controller
    {
        [HttpGet]
       public IEnumerable<Objekt> Get()
        {
            using (var Context = new HemnetContext())
            {
                return Context.Objekt.ToList();
            }
        }


    }
}
