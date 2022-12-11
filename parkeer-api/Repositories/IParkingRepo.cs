namespace parkeer_api.Repositories
{
    public interface IParkingRepo
    {
        IEnumerable<Parking> GetParkings();
        Parking GetParkingById(int id);
    }
}
