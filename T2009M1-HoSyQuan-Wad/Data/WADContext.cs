using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WAD.Models;

namespace WAD.Data
{
    public class WADContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public WADContext() : base("name=WADContext")
        {
        }

        public System.Data.Entity.DbSet<WAD.Models.Exam> Exams { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entry(Exam exam)
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }
    }
}