using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {

        new string[] wow = { "wow1", "wow2" };

        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return wow;
        }

        

        // GET api/values/5
        public string Get(int id)
        {

            return wow[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
             
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
