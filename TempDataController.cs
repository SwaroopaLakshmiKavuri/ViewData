using EgViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgViewData.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmpTempData()
        {

            var emp = new List<Employee>
            {
                new Employee{EmpId=1,Name="Swaroopa"},
                new Employee{EmpId=2,Name="Anusha"},
                new Employee{EmpId=3,Name="Gayathri"},
                new Employee{EmpId=4,Name="Anjali"},
            };

            TempData["Employee"] = emp;
            return View();
        }
    }
}