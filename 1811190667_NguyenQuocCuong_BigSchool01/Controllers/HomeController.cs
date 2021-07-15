using _1811190667_NguyenQuocCuong_BigSchool01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _1811190667_NguyenQuocCuong_BigSchool01.ViewModels;
using Microsoft.AspNet.Identity;

namespace _1811190667_NguyenQuocCuong_BigSchool01.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CourseViewModel
            {
                UpcommingCourses = upcommingCourses,
                //Followings = _dbContext.Followings.Where(a => a.FolloweeId == user).ToList(),
                Attendances = _dbContext.Attendances.Where(a => a.AttendeeId == user).ToList(),
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }
    }
}