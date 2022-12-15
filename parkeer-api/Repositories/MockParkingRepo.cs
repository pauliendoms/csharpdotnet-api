namespace parkeer_api.Repositories
{
    public class MockParkingRepo : IParkingRepo
    {
        List<Parking> parkings = new List<Parking>();

        public MockParkingRepo()
        {   
            /*
            parkings.Add(new Parking(1, 500, 350, 1));
            parkings.Add(new Parking(2, 540, 354, 2));
            parkings.Add(new Parking(3, 600, 360, 1));
            parkings.Add(new Parking(4, 403, 450, 3));
            */
        }

        public IEnumerable<Parking> GetParkings()
        {
            return parkings;
        }

        public Parking GetParkingById(int i)
        {
            return parkings[i];
        }

        public void AddParking(Parking parking)
        {
            parkings.Add(parking);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
