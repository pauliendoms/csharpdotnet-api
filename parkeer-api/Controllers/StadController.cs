using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using parkeer_api.Dto;
using parkeer_api.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace parkeer_api.Controllers
{
    [Route("api/stad")]
    [ApiController]
    public class StadController : ControllerBase
    {
        private readonly IStadRepo _repo;
        private readonly IMapper _map;

        public StadController(IStadRepo repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }
        // GET: api/<StadController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_map.Map<IEnumerable<StadReadDto>>(_repo.GetSteden()));
        }

        // GET api/<StadController>/5
        [HttpGet("{id}", Name="GetStadById")]
        public ActionResult GetStadById(int id)
        {
            var stad = _repo.GetStadById(id);
            if(stad != null) {
                return Ok(_map.Map<ParkingReadDto>(stad));
            }
            return NotFound();
        }

        // POST api/<StadController>
        [HttpPost]
        public ActionResult<Stad> AddStad(StadWriteDto s)
        {
            var stad = _map.Map<Stad>(s);

            _repo.AddStad(stad);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetStadById), new {id = stad.id}, stad);
        }

        // PUT api/<StadController>/5
        [HttpPut("{id}")]
        public ActionResult<Stad> Put(int id, StadWriteDto s)
        {
            var stad = _map.Map<Stad>(s);

            stad.id = id;

            _repo.UpdateStad(stad);
            _repo.SaveChanges();

            return Ok(stad);
        }

        // DELETE api/<StadController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var stad = _repo.GetStadById(id);
            if(stad == null) {
                return NotFound();
            }

            _repo.DeleteStad(stad);
            _repo.SaveChanges();

            return Ok();
        }
    }
}
