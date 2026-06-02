namespace IncidentDemo.Dtos
{
    public class IncidentListDto
    {
        public int id { get; set; }
        public string priority { get; set; }
        public string status { get; set; }
        public string assignedTo { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
