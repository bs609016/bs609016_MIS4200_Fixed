using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bs609016_MIS4200_Fixed.Models
{
    public class CourseDetail
    {
        public int courseDetailId { get; set; }
        public int seatsAvalible { get; set; }
        public int courseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual Professor Professor { get; set; }


    }
}