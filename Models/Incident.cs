namespace IncidentDemo.Models
{
    //Entity model 
    public class Incident
    {
        public int id { get; set; }
        public string title { get; set; }//
        public string description { get; set; }//
        public string category { get; set; }//
        public string priority { get; set; }
        public string status { get; set; }
        public string reporterName { get; set; }//
        public string reporterEmail { get; set; }//
        public string assignedTo { get; set; }
        public string comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
