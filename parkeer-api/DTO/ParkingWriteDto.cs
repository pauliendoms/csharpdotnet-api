namespace parkeer_api.Dto
{
    public class ParkingWriteDto
    {
        public int capacity { get; set; }
        public int free_spaces { get; set; }
        public int city_id { get; set; }
    }
}