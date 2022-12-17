using System.ComponentModel.DataAnnotations;

namespace parkeer_api.Dto
{
    public class StadWriteDto
    {
        [Required]
        public string name { get; set; }
    }
}