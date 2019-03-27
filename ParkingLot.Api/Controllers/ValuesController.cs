using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLot.Core.Interface;

namespace ParkingLot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IUser iUser { get; private set; }

        public ValuesController(IUser iUser )
        {
            this.iUser = iUser;
        }

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{



        //    return new string[] { "value1", "value2" };


        //}

        //[HttpGet]
        //public ActionResult<string> Get(int id)
        //{
        //    return  Ok(iUsuarios.GetUsuario) ;
        //}

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return iUser.GetUser("Juan");
        }


        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return Ok(iUsuarios.GetUsuario("Juan"));
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
