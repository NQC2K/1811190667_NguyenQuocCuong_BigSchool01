using _1811190667_NguyenQuocCuong_BigSchool01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1811190667_NguyenQuocCuong_BigSchool01.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage ="Place is required")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [FutureDate]
        public string Date { get; set; }
        [Required(ErrorMessage = "Time is required")]
        [ValidTime]
        public string Time { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}