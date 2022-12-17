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

        public void AddParking(Parking parking)
        {
            _context.parkings.Add(parking);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateParking(Parking parking)
        {
            _context.parkings.Update(parking);
        }

        public void DeleteParking(Parking parking)
        {
            _context.parkings.Remove(parking);
        }
    }

}

