using CRUD_MVC_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CRUD_MVC_EntityFramework.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        EmpContext s = new EmpContext();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee obj)
        {
            s.Employees.Add(obj);
            s.SaveChanges();
            return RedirectToAction("Read");
        }
        public ActionResult Read()
        {
            var emp = s.Employees.ToList();
            return View(emp);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = s.Employees.Where(x => x.Eno == id).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Employee obj)
        {
            var data = s.Employees.FirstOrDefault(x => x.Eno == id);
            if (data != null)
            {
                data.Ename = obj.Ename;
                data.Job = obj.Job;
                data.Salary = obj.Salary;
                s.SaveChanges();
                return RedirectToAction("Read");
            }
            else
                return View();
        }
        public ActionResult Delete(int id)
        {
            var emp = s.Employees.FirstOrDefault(x => x.Eno == id);
            if (emp != null)
            {
                s.Employees.Remove(emp);
                s.SaveChanges();
                return RedirectToAction("Read");
            }
            else
                return View();
        }
    }
}