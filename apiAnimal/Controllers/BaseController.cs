using apiAnimal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiAnimal.Controllers
{
    public class BaseController : ApiController
    {
        // GET api/<controller>
        public petstationEntities db = new petstationEntities();

    }

}