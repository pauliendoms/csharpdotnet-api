using System.ComponentModel.DataAnnotations;

namespace parkeer_api.Dto
{
    public class ParkingWriteDto
    {
        [Required]
        public int capacity { get; set; }
        [Required]
        public int free_spaces { get; set; }
        [Required]
        public int city_id { get; set; }
    }
}