using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace learn_ajax.Controllers
{
    public class ValuesController : ApiController
    {
        /*
        
        // GET api/values
        public EInumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

             
        */

        // GET api/values/5
        public string Get(/*int id*/ string Name, int Number)
        {
            return "Data: Name - " + Name + ", Number - " + Number;

            //return "value";
        }

        /*
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        */
    }
}
