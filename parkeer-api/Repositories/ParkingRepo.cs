using parkeer_api.Contexts;

namespace parkeer_api.Repositories
{
    public class ParkingRepo : IParkingRepo
    {

        private readonly ParkingContext _context;

        public ParkingRepo(ParkingContext context)
        {
            _context = context;
        }
        public IEnumerable<Parking> GetParkings()
        {
            return _context.parkings;
        }

        public Parking GetParkingById(int i)
        {
            return _context.parkings.FirstOrDefault<Parking>(t => t.id == i);
        }
    }

}

