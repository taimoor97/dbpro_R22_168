using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanManagementSystem.Models
{
    public class LoanApplicationmodel
    {
        [Required]
        [Display(Name = "Application Id")]
        public int AppId { get; set; }

        [Required]
        [Display(Name = "Reason of Loan")]
        public string Reasonofloan { get; set; }

        [Required]
        [Display(Name = "Loan Amount")]
        public decimal LoanAmount { get; set; }

        [Required]
        [Display(Name = "Payback Time")]
        public DateTime Paybacktime { get; set; }

        [Required]
        [Display(Name = "Loan Id")]
        public int LoanId { get; set; }

        [Required]
        [Display(Name = "CNIC")]
        public int Cnic { get; set; }
    }
}