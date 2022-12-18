namespace parkeer_api.Repositories
{
    public interface IStadRepo
    {
        IEnumerable<Stad> GetSteden();
        Stad GetStadById(int id);

        void AddStad(Stad stad);
        void SaveChanges();
        void UpdateStad(Stad stad);
        void DeleteStad(Stad stad);

        IEnumerable<Parking> GetParkingsByStad(int city_id);
    }
}