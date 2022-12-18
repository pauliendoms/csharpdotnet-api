using parkeer_api.Contexts;

namespace parkeer_api.Repositories
{
    public class StadRepo : IStadRepo
    {

        private readonly ParkingContext _context;

        public StadRepo(ParkingContext context) {
            _context = context;
        }
        public void AddStad(Stad stad)
        {
            _context.steden.Add(stad);
        }

        public void DeleteStad(Stad stad)
        {
            _context.steden.Remove(stad);
        }

        public IEnumerable<Parking> GetParkingsByStad(int city_id)
        {
            return _context.parkings.Where(a => a.city_id == city_id);
        }

        public Stad GetStadById(int id)
        {
            return _context.steden.FirstOrDefault<Stad>(t => t.id == id);
        }

        public IEnumerable<Stad> GetSteden()
        {
            return _context.steden;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateStad(Stad stad)
        {
        }

        
    }
}