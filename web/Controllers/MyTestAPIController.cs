using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Helpers;
namespace web.Controllers
{
    [Produces("application/json")]
    [Route("api/MyTestAPI")]
    public class MyTestAPIController : Controller
    {
        // GET: api/MyTestAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/MyTestAPI/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            SQLHelper helper =new SQLHelper();
          int outPut=  helper.Multi(2,id);
            return outPut.ToString();
        }
        
        // POST: api/MyTestAPI
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/MyTestAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
