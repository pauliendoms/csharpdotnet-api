using Microsoft.AspNetCore.Mvc;
using parkeer_api.Repositories;

namespace parkeer_api.Controllers
{
    [Route("api/parking")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        MockParkingRepo _repo = new MockParkingRepo();
        // GET: api/<ParkingController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repo.getParkings());
        }

        // GET api/<ParkingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_repo.getParkingById(id));
        }

        // POST api/<ParkingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ParkingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ParkingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
