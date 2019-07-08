using doranekoWebAspCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doranekoWebAspCSharp.Controllers
{
    public class EmployeeController : Controller
    {

        public static List<Employee> empList = new List<Employee>{
   new Employee{
      ID = 1,
      Name = "Allan",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 23
   },
	
   new Employee{
      ID = 2,
      Name = "Carson",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 45
   },
	
   new Employee{
      ID = 3,
      Name = "Carson",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 37
   },
	
   new Employee{
      ID = 4,
      Name = "Laura",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 26
   },
	
};


        public ActionResult Index()
        {
            var employees = from e in empList orderby e.ID select e;
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = empList.Single(m => m.ID == id);
                if (TryUpdateModel(employee))
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}