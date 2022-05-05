using System.Data;
using System.IO;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAssignment2.Models;
using NetCoreAssignment2.Services.Interfaces;

namespace NetCoreAssignment2.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private IPersonService _personService;


        public RookiesController(ILogger<RookiesController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            return View(_personService.GetAll());
        }

        public IActionResult GetMaleMembers()
        {
            if (_personService == null)
            {
                return null;
            }

            var maleList = _personService.GetMaleMembers();

            return View(maleList);
        }

        public IActionResult GetOldest()
        {
            if (_personService == null)
            {
                return null;
            }

            var oldest = _personService.GetOldestMember();

            return View(oldest);
        }

        public IActionResult GetFullNameList()
        {
            if (_personService == null)
            {
                return null;
            }

            var fullNameList = _personService.GetMembersWithFullName();

            return View(fullNameList);
        }

        public IActionResult GetMemberByValue(int i)
        {
            if (_personService == null)
            {
                return null;
            }
            ViewBag.Header = i;

            return View(_personService.GetCompareWith2000List(i));
        }

        public FileResult Export()
        {
            DataTable dt = new DataTable("Members");
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("First Name"),
                                            new DataColumn("Last Name"),
                                            new DataColumn("Gender"),
                                            new DataColumn("Dob"),
                                            new DataColumn("Phone Number"),
                                            new DataColumn("Birth Place"),
                                            new DataColumn("Graduated"),
                                            });

            foreach (var person in _personService.People)
            {
                dt.Rows.Add(person.FirstName, person.LastName, person.Gender, person.Dob,
                person.PhoneNumber, person.BirthPlace, person.IsGraduated);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Members.xlsx");
                }
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person newPerson)
        {
            _personService.Create(newPerson);
            return RedirectToAction("Index", "Rookies");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var findPerson = _personService.GetPersonById((int)id);
                return View(findPerson);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Edit(Person editPerson)
        {
            _personService.Edit(editPerson);
            return RedirectToAction("Index", "Rookies");
        }

        public IActionResult ConfirmDelete(int id)
        {
            _personService.Delete(id);
            return RedirectToAction("Index", "Rookies");
        }
    }
}