using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanManagementSystem.Models;
namespace LoanManagementSystem.Controllers
{
    public class LoanApprovalController : Controller
    {
        // GET: LoanApproval
        public ActionResult Index()
        {
            DB56Entities db = new DB56Entities();
            var laa = db.Loan_Approval.ToList();
            List<LoanApproval> l = new List<LoanApproval>();
            foreach(var a in laa)
            {
                LoanApproval la = new LoanApproval();
                la.ApprovalId = a.Approval_ID;
                la.NoOfInstallments = a.No_of_Installments;
                la.InstallmentsAmount = a.Installments_Amount;
                la.Description = a.Discription;
                la.ApprovedDate = a.Approved_date;
                l.Add(la);
            }



            return View(l);
        }

        // GET: LoanApproval/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoanApproval/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanApproval/Create
        [HttpPost]
        public ActionResult Create(LoanApproval model)
        {
            try
            {
                DB56Entities db = new DB56Entities();
                Loan_Approval la = new Loan_Approval();
                la.Approval_ID= model.ApprovalId;
                la.No_of_Installments = model.NoOfInstallments;
                la.Installments_Amount = model.InstallmentsAmount;
                la.Discription = model.Description;
                la.Approved_date = DateTime.Now;
                
                db.Loan_Approval.Add(la);
                db.SaveChanges();
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanApproval/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoanApproval/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, LoanApproval collection)
        {
            try
            {
                DB56Entities db = new DB56Entities();
                Loan_Approval la = new Loan_Approval();
                var a = db.Loan_Approval.Where(x => x.Approval_ID == id).SingleOrDefault();
                a.No_of_Installments = collection.NoOfInstallments;
                a.Installments_Amount = collection.InstallmentsAmount;
                a.Discription = collection.Description;
                a.Approved_date = collection.ApprovedDate;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanApproval/Delete/5
        public ActionResult Delete(int? id)
        {
            DB56Entities db = new DB56Entities();
            var a = db.Loan_Approval.Where(x => x.Approval_ID == id).SingleOrDefault();
            var result = db.Loan_Approval.Remove(a);
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        // POST: LoanApproval/Delete/5
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
                return RedirectToAction("Index");
            }
        }
    }
}
