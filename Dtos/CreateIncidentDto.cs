using System.ComponentModel.DataAnnotations;

namespace IncidentDemo.Dtos
{
    public class CreateIncidentDto
    {
        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string reporterName { get; set; }

        [Required]
        [EmailAddress]
        public string reporterEmail { get; set; }

    }
}
