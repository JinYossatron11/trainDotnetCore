using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yossatron.MyName;
using System.Net.Http;
namespace MyNameApi.Controllers
{
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        // // GET api/name
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" , "value3" };
        // }

        // // GET api/name/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/name
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/name/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/name/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
        [HttpGet("")]
        public IActionResult Get(){
            Name name = new Name();
            dynamic obj = new ExpandoObject();
            obj.name = name.Get();
            return Ok(obj);
       }
       [HttpGet("company")]

       public async Task<IActionResult> GetCompany(){
           HttpClient client = new HttpClient();
           HttpResponseMessage response = await client.GetAsync("http://10.10.1.8/api/data/companies/listed");
           string result = await response.Content.ReadAsStringAsync();
           return Ok(result);
       }
    }
}
