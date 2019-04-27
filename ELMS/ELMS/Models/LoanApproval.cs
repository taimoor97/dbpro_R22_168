using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagementSystem.Models
{
    public class LoanApproval
    {
        [Required]
        [Display(Name = "Approval Id")]
        public int ApprovalId { get; set; }

        [Required]
        [Display(Name = "No of installments")]
        public int NoOfInstallments { get; set; }

        [Required]
        [Display(Name = "Installments Amount")]
        public decimal InstallmentsAmount { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Approved Date")]
        public DateTime ApprovedDate { get; set; }
    }
}