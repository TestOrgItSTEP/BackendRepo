
using IncidentDemo.Dtos;
using IncidentDemo.Service;
using Microsoft.AspNetCore.Mvc;

namespace IncidentDemo.Controllers
{
    public class HomeController : Controller
    {
        readonly IncidentService _incidentService;
        public HomeController(IncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var incidents = _incidentService.GetAll();
            return View(incidents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateIncidentDto());
        }

        [HttpPost]
        public IActionResult Create(CreateIncidentDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            _incidentService.CreateIncident(dto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var incident = _incidentService.GetDetails(id);
            if (incident == null)
            {
                return NotFound();
            }
            return View(incident);
        }
        [HttpPost]
        public IActionResult UpdateStatus(UpdateStatusDto obj)
        {
            _incidentService.UpdateIncident(obj);
            return RedirectToAction(nameof(Details), new {id = obj.id});
        }

    }

}
