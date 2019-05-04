using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanManagementSystem.Models;

namespace LoanManagementSystem.Controllers
{
    public class LoanApplicationController : Controller
    {
        // GET: LoanApplication
        public ActionResult Index()
        {
            DB56Entities db = new DB56Entities();
            var laa = db.Loan_Application.ToList();
            List<LoanApplicationmodel> l = new List<LoanApplicationmodel>();
            foreach (var a in laa)
            {
                LoanApplicationmodel la = new LoanApplicationmodel();
                la.Cnic =Convert.ToInt32(a.CNIC);
                la.LoanAmount = a.Loan_Amount;
                la.Paybacktime = a.Pay_Back_time;
                la.Reasonofloan = a.Reason_Loan;
                la.LoanId = a.Loan_ID;
                la.AppId = a.App_ID;
                l.Add(la);
            }
            return View(l);
        }

        // GET: LoanApplication/Details/5
        public ActionResult Details(int id)
        {
            DB56Entities db = new DB56Entities();
            var laa = db.Loan_Application.ToList();
            List<Loan_Application> l = new List<Loan_Application>();
            foreach (var a in laa)
            {
                Loan_Application la = new Loan_Application();
                la.CNIC = a.CNIC;
                la.Loan_Amount = a.Loan_Amount;
                la.Pay_Back_time = a.Pay_Back_time;
                la.Loan_ID = a.Loan_ID;
                la.App_ID = a.App_ID;
                la.Reason_Loan = a.Reason_Loan;
                l.Add(la);
            }
            return View(l);
        }

        // GET: LoanApplication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanApplication/Create
        [HttpPost]
        public ActionResult Create(LoanApplicationmodel collection)
        {
            try
            {
                DB56Entities db = new DB56Entities();
                Loan_Application la = new Loan_Application();
                la.Reason_Loan = collection.Reasonofloan;
                la.CNIC =Convert.ToString(collection.Cnic);
                la.Loan_Amount = collection.LoanAmount;
                la.Pay_Back_time = collection.Paybacktime;
                la.Loan_ID = collection.LoanId;
                la.App_ID = collection.AppId;
                db.Loan_Application.Add(la);
                db.SaveChanges();





                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanApplication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoanApplication/Edit/5
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

        // GET: LoanApplication/Delete/5
        public ActionResult Delete(int? id)
        {
            DB56Entities db = new DB56Entities();
            var a = db.Loan_Application.Where(x => x.App_ID == id).SingleOrDefault();
            var result = db.Loan_Application.Remove(a);
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        // POST: LoanApplication/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
