using eProject.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class EProject_DbContext : DbContext
    {
        public EProject_DbContext() : base("name=EProject_Sem3")
        {
            //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<EProject_DbContext, Configuration>("EProject_Sem3"));
        }

        public virtual DbSet<AdminLogin> AdminLogins { get; set; }
        public virtual DbSet<CompanyDetails> CompanyDetails { get; set; }
        public virtual DbSet<EmpRegister> EmpRegisters { get; set; }
        public virtual DbSet<HospitalInfo> HospitalInfos { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<PoliciesOnEmployee> PoliciesOnEmployees { get; set; }
        public virtual DbSet<PolicyApprovalDetails> PolicyApprovalDetails { get; set; }
        public virtual DbSet<PolicyRequestDetails> PolicyRequestDetails { get; set; }
        public virtual DbSet<PolicyTotalDescription> PolicyTotalDescriptions { get; set; }

    }
}