using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SparkfishRestAPI.Services;

namespace SparkfishRestAPI.Controllers
{
    public class ListifyController : ApiController
    {

        // GET api/<controller>/5
        [Route("Listify/{begin:int}/{end:int}/{index:int}")]
        public IHttpActionResult Get(int begin, int end, int index)
        {
            try
            {
                IEnumerable<int> p1;
                p1 = ListifyComputation.retrieveRange(begin, end);
                var p1List = ListifyComputation.ToList(p1);
                return Ok(ListifyComputation.retrieveValueInList(p1List, index));
            }
            catch
            {
                return BadRequest("An error has occurred");
            }
        }
        

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}