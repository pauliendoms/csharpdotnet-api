using Microsoft.AspNetCore.Mvc;
using parkeer_api.Repositories;

namespace parkeer_api.Controllers
{
    [Route("api/parking")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingRepo _repo;

        public ParkingController(IParkingRepo repo)
        {
            _repo = repo; 
        }
        // GET: api/<ParkingController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repo.GetParkings());
        }

        // GET api/<ParkingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_repo.GetParkingById(id));
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
