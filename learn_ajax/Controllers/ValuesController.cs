using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

namespace learn_ajax.Controllers
{
    public class ValuesController : ApiController
    {
        //GET api/values/
        public string Get(string country)
        {
            var dictionary = new Dictionary<int, string>();

            switch (country)
            {
                case "1":
                    {
                        dictionary.Add(1, "Paris");
                        dictionary.Add(2, "Marseille");
                        break;
                    };
                case "2":
                    {
                        dictionary.Add(1, "NY");
                        dictionary.Add(2, "LA");
                        break;
                    };
                default:
                    {
                        break;
                    };
            }

            return JsonConvert.SerializeObject(dictionary, Formatting.Indented);
        }

        /*
        // GET api/values
        public EInumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
            
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

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
