using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanManagementSystem.Models;

namespace LoanManagementSystem.Controllers
{
    public class LoanPolicyController : Controller
    {
        // GET: LoanPolicy
        public ActionResult Index()
        {
            DB56Entities db = new DB56Entities();
            var laa = db.Loan_Policy.ToList();
            List<LoanPolicy> l = new List<LoanPolicy>();
            foreach (var a in laa)
            {
                LoanPolicy la = new LoanPolicy();
                la.LoanId = a.Loan_ID;
                la.LoanType = a.Loan_type;
                la.LoanDiscription = a.Loan_Discription;
                la.Amount = a.Amount;
                la.MaxInstallments = a.Max_Installments;
                l.Add(la);
            }
            return View(l);
        }

        // GET: LoanPolicy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoanPolicy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanPolicy/Create
        [HttpPost]
        public ActionResult Create(LoanPolicy model)
        {
            try
            {
                // TODO: Add insert logic here
                DB56Entities db = new DB56Entities();
                Loan_Policy la = new Loan_Policy();
                la.Loan_ID = model.LoanId;
                la.Loan_type = model.LoanType;
                la.Loan_Discription = model.LoanDiscription;
                la.Amount = model.Amount;
                la.Max_Installments = model.MaxInstallments;

                db.Loan_Policy.Add(la);
                db.SaveChanges();
               // return View();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanPolicy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoanPolicy/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, LoanPolicy collection)
        {
            try
            {
                // TODO: Add update logic here
                DB56Entities db = new DB56Entities();
                Loan_Policy la = new Loan_Policy();
                var a = db.Loan_Policy.Where(x => x.Loan_ID == id).SingleOrDefault();
                a.Loan_type = collection.LoanType;
                a.Loan_Discription = collection.LoanDiscription;
                a.Amount = collection.Amount;
                a.Max_Installments = collection.MaxInstallments;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanPolicy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoanPolicy/Delete/5
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
                return View();
            }
        }
    }
}
