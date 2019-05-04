using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagementSystem.Models
{
    public class LoanPolicy
    {
        [Required]
        [Display(Name = "Loan Id")]
        public int LoanId { get; set; }

        [Required]
        [Display(Name = "Loan Type")]
        public string LoanType { get; set; }

        [Required]
        [Display(Name = "Loan Discription")]
        public string LoanDiscription { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Maximum Installments")]
        public int MaxInstallments { get; set; }
    }
}