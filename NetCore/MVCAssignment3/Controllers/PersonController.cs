using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAssignment3.Models.DTO;
using MVCAssignment3.Services.Interfaces;

namespace MVCAssignment3.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {

            return View(_personService.ListAll());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewPersonDTO newPersonDTO)
        {
            var newPerson = _personService.Create(newPersonDTO);
            return RedirectToAction("Index", "Person");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var updatePerson = _personService.GetPersonById((int)id);
            return View(updatePerson);
        }

        [HttpPost]
        public IActionResult Edit(EditPersonDTO editPersonDTO)
        {
            var updatePerson = _personService.Edit(editPersonDTO);
            return RedirectToAction("Index", "Person");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var detailPerson = _personService.GetPersonById((int)id);
            return View(detailPerson);
        }

        public IActionResult Delete(int? id, string name)
        {
            if (id == null)
            {
                return NotFound();
            }
            _personService.Delete((int)id);

            TempData["Message"] = name + " was removed from the list successfully!";
            return RedirectToAction("Index", "Person");
        }
    }
}