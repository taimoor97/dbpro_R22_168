﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB56Entities : DbContext
    {
        public DB56Entities()
            : base("name=DB56Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Loan_Application> Loan_Application { get; set; }
        public virtual DbSet<Loan_Approval> Loan_Approval { get; set; }
        public virtual DbSet<Loan_Policy> Loan_Policy { get; set; }
        public virtual DbSet<Loan_Info> Loan_Info { get; set; }
        public virtual DbSet<EmployeListReport> EmployeListReports { get; set; }
        public virtual DbSet<LoanApprovalReport> LoanApprovalReports { get; set; }
        public virtual DbSet<LoanPolicyReport> LoanPolicyReports { get; set; }
    }
}
