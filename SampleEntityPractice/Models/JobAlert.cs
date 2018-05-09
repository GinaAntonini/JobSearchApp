using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleEntityPractice.Models
{
    public class JobAlert
    {
        public virtual int Id { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string Location { get; set; }
        public virtual int Salary { get; set; }
    }
}