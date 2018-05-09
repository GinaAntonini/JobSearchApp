using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleEntityPractice.Models
{
    public class Job
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Type { get; set; }
        public virtual string Description { get; set; }
        public virtual string Qualifications { get; set; }
        public virtual DateTime DateApplied { get; set; }
    }
}