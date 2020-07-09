using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandCreateDto
    {
        //[Required]
        public string HowTo { get; set; }
        //[Required]
        public string Line { get; set; }
        //[Required]
        public string Platform { get; set; }
    }
}