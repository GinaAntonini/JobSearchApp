using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleEntityPractice.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("SampleEntityPractice") {}

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAlert> JobAlerts { get; set; }
    }
}