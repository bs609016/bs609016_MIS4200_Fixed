using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bs609016_MIS4200_Fixed.Models
{
    public class Professor
    {
        public int professorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}