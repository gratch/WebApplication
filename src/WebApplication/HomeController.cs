using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace WebApplication
{
    public class HomeController:ApiController
    {
        public IEnumerable<int> GetValues()
        {
            return Enumerable.Range(0, 20);
        } 
    }
}