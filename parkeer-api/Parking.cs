namespace parkeer_api
{
    public class Parking
    {
        public int id { get; set; }
        public int capacity { get; set; }
        public int free_spaces { get; set; }
        public int city_id { get; set; }

        public Parking(int id, int capacity, int free_spaces, int city_id)
        {
            this.id = id;
            this.capacity = capacity;
            this.free_spaces = free_spaces;
            this.city_id = city_id;
        }
    }
}
