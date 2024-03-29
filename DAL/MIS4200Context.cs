﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bs609016_MIS4200_Fixed.Models;
using System.Data.Entity;

namespace bs609016_MIS4200_Fixed.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
    }
}