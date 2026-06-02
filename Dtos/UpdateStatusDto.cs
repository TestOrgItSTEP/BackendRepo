using System.ComponentModel.DataAnnotations;

namespace IncidentDemo.Dtos;

public class UpdateStatusDto
{
    [Required]
    public int id { get; set; }

    [Required]
    public string status { get; set; }

    public string comment { get; set; }
}
