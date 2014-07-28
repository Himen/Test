using System;
using System.Collections.Generic;
using System.Data.Entity;
using HR.Core.Models;

namespace HR.DataAccess.EF
{
    public class HR_Context : DbContext
    {
        static HR_Context()
        {
            Database.SetInitializer<HR_Context>(new CreateDatabaseIfNotExists<HR_Context>());
        }

        public HR_Context()
            : base("Name=HRConnectionString")
        {
 
        }

        public DbSet<Account>  Accounts { get; set; }
    }
}
