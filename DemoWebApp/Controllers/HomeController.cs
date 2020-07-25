using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using DataLibrary.BusinessLogic;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(Employee model)
        {
            if (ModelState.IsValid)
            {
                int records = EmployeeProcessor.CreateEmployee(
                    model.EmployeeId,
                    model.FirstName,
                    model.LastName,
                    model.Email_Id,
                    model.Password);
                    //Crypto.Hash(model.Password));
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ViewEmployees()
        {
            var data = EmployeeProcessor.LoadEmployees();
            List<Employee> employee = new List<Employee>();
            foreach(var row in data)
            {
                employee.Add(new Employee
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Email_Id = row.Email_Id,
                    Password = row.Password
                });
            }

            return View(employee);
        }
    }
}