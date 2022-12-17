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
        [HttpGet("{id}", Name="GetParkingById")]
        public ActionResult GetParkingById(int id)
        {
            var parking = _repo.GetParkingById(id);
            if (parking != null) {
                return Ok(_map.Map<ParkingReadDto>(parking));
            }
            return NotFound();
        }

        // POST api/<ParkingController>
        [HttpPost]
        public ActionResult<Parking> AddParking(ParkingWriteDto p)
        {
            var parking = _map.Map<Parking>(p);

            _repo.AddParking(parking);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetParkingById), new {id = parking.id}, parking);
        }

        // PUT api/<ParkingController>/5
        [HttpPut("{id}")]
        public ActionResult<Parking> Put(int id, ParkingWriteDto p)
        {
            var existing = _repo.GetParkingById(id);
            if(existing == null) {
                return NotFound();
            }

            _map.Map(p, existing);

            _repo.UpdateParking(existing);
            _repo.SaveChanges();

            return Ok(existing);
        }

        // DELETE api/<ParkingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var parking = _repo.GetParkingById(id);
            if (parking == null) {
                return NotFound();
            }
            
            _repo.DeleteParking(parking);
            _repo.SaveChanges();

            return Ok();
        }

        [HttpGet("{id:int}/parkeer")]
        public ActionResult Parkeer(int id)
        {
            var parking = _repo.GetParkingById(id);
            if (parking == null) {
                return NotFound();
            }

            parking.free_spaces -= 1;

            _repo.UpdateParking(parking);
            _repo.SaveChanges();

            return Ok(parking);
        }
    }
}
