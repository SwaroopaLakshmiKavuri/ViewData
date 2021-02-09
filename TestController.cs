using EgViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgViewData.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Show()
        {
            var emp = new List<Employee>
            {
                new Employee{EmpId=1,Name="Swaroopa"},
                new Employee{EmpId=2,Name="Anusha"},
                new Employee{EmpId=3,Name="Gayathri"},
                new Employee{EmpId=4,Name="Anjali"},

            };
            return View(emp);
        }
        public ActionResult EmpViewData()
        {
            return Show();

        }
    }
}