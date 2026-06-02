using IncidentDemo.Dtos;
using IncidentDemo.Models;
using System.Security.Cryptography;

namespace IncidentDemo.Service
{
    public class IncidentService
    {
        //local memory storage for incidents
        readonly List<Incident> _incidents = new List<Incident>();
        int genid = 1;
        public void CreateIncident(CreateIncidentDto obj)
        {
            var incident = new Incident
            {
                id = genid,
                title = obj.title,
                description = obj.description,
                category = obj.category,
                priority = "Low",
                status = "New",
                CreatedAt = DateTime.Now,
                reporterName = obj.reporterName,
                reporterEmail = obj.reporterEmail,
                comment = "",
                assignedTo = "Test1"
            };
            _incidents.Add(incident);
        }

        public List<IncidentListDto> GetAll ()
        {
            return _incidents.Select(_incidents => new IncidentListDto
            {
                id = _incidents.id,
                priority = _incidents.priority,
                status = _incidents.status,
                assignedTo = _incidents.assignedTo,
                CreatedAt = _incidents.CreatedAt
            }).ToList();
        }
        
        public IncidentDetailsDto GetDetails(int id)
        {
            var incident = _incidents.FirstOrDefault(i => i.id == id);
            if (incident == null)
            {
                return null;
            }
            return new IncidentDetailsDto
            {
                id = incident.id,
                title = incident.title,
                description = incident.description,
                category = incident.category,
                priority = incident.priority,
                status = incident.status,
                reporterName = incident.reporterName,
                reporterEmail = incident.reporterEmail,
                assignedTo = incident.assignedTo,
                CreatedAt = incident.CreatedAt
            };
        }
        public void UpdateIncident(UpdateStatusDto obj)
        {
            var incident = _incidents.FirstOrDefault(i => i.id == obj.id);
            if (incident == null)
            {
                return;
            }
            incident.status = obj.status;
            incident.comment = obj.comment; 
        }
    }
}
