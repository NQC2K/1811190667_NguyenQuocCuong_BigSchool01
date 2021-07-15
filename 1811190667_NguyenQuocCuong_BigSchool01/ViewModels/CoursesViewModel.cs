using _1811190667_NguyenQuocCuong_BigSchool01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811190667_NguyenQuocCuong_BigSchool01.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}