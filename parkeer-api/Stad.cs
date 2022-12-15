namespace parkeer_api
{
    public class Stad
    {
        public int id { get; set; }
        public string name { get; set; }

        public Stad(int id, string name) {
            this.id = id;
            this.name = name;
        }
    }
}
