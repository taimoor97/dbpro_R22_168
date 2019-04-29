using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanManagementSystem.Models;
namespace LoanManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()

        {
            DB56Entities db = new DB56Entities();
            var laa = db.Employees.ToList();
            List<Employeemodel> l = new List<Employeemodel>();
            foreach (var a in laa)
            {
                Employeemodel la = new Employeemodel();
                la.CNIC = a.CNIC;
                la.Name = a.Name;
                la.Password = a.Password;
                la.Email = a.Email;
                la.Salary = a.Salary;
                la.Gender = a.Gender;
                la.Address = a.Address;
                l.Add(la);
            }
            return View(l);

        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employeemodel model)
        {
            try
            {
                // TODO: Add insert logic here
                DB56Entities db = new DB56Entities();
                Employee la = new Employee();
                la.CNIC = model.CNIC;
                la.Name = model.Name;
                la.Password = model.Password;
                la.Email = model.Email;
                la.Salary = model.Salary;
                la.Gender = model.Gender;
                la.Address = model.Address;

                db.Employees.Add(la);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(string id)
        {
            DB56Entities db = new DB56Entities();
            var a = db.Employees.Where(x => x.CNIC ==  id).SingleOrDefault();
            var result = db.Employees.Remove(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
