namespace parkeer_api.Dto
{
    public class ParkingReadDto 
    {
        public int id { get; set; }
        public int capacity { get; set; }
        public int free_spaces { get; set; }
        public int city_id { get; set; }
    }
}
