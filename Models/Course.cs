using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bs609016_MIS4200_Fixed.Models
{
    public class Course
    {
        
        public int courseId { get; set; }
        public string description { get; set; }
        public string section { get; set; }
        public string professor { get; set; }
        public ICollection<CourseDetail> CourseDetail { get; set; }

        public int studentId { get; set; }
        public virtual Student Student{ get; set; }
    }
}