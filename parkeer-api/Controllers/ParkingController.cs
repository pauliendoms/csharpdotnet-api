using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using parkeer_api.Dto;
using parkeer_api.Repositories;

namespace parkeer_api.Controllers
{
    [Route("api/parking")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingRepo _repo;
        private readonly IMapper _map;

        public ParkingController(IParkingRepo repo, IMapper map)
        {
            _repo = repo; 
            _map = map;
        }
        // GET: api/<ParkingController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_map.Map<IEnumerable<ParkingReadDto>>(_repo.GetParkings()));
        }

        // GET api/<ParkingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_map.Map<ParkingReadDto>(_repo.GetParkingById(id)));
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
