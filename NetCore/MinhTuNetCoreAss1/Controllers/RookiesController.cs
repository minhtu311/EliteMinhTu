using System.Collections.Generic;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhTuNetCoreAss1.Models;
using MinhTuNetCoreAss1.Service;

namespace MinhTuNetCoreAss1.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;

        public static List<Person> members = PersonService.MembersInitializing();

        public RookiesController(ILogger<RookiesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMaleMembers()
        {
            var isMaleList = PersonService.GetMaleMembers(members);

            return Ok(isMaleList);
        }

        public IActionResult Oldest()
        {
            var oldest = PersonService.GetOldestMember(members);

            return Ok(oldest);
        }

        public IActionResult FullNameList()
        {
            var fullNameList = PersonService.GetMembersWithFullName(members);

            return Ok(fullNameList);
        }

        public IActionResult ChooseList2000(int i)
        {

            if (i == 1)
            {
                return RedirectToAction("Is2000List", "Rookies");
            }
            else if (i == 2)
            {
                return RedirectToAction("GreaterThan2000", "Rookies");
            }
            else
            {
                return RedirectToAction("LessThan2000", "Rookies");
            }
        }

        public IActionResult Is2000List()
        {
            var check2000List = PersonService.Check2000(1, members);

            return Ok(check2000List);
        }

        public IActionResult GreaterThan2000()
        {
            var check2000List = PersonService.Check2000(2, members);

            return Ok(check2000List);
        }

        public IActionResult LessThan2000()
        {
            var check2000List = PersonService.Check2000(3, members);

            return Ok(check2000List);
        }

        public FileResult Export()
        {
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("FirstName"),
                                            new DataColumn("LastName"),
                                            new DataColumn("Gender"),
                                            new DataColumn("Dob"),
                                            new DataColumn("Phone number"),
                                            new DataColumn("Birth place"),
                                            new DataColumn("Is graduated"),
                                            });

            foreach (var person in members)
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
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
                }
            }
        }
    }
}