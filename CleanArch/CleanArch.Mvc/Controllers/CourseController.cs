using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _coursesService;

        public CourseController(ICourseService courseService)
        {
            _coursesService = courseService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _coursesService.GetCourses();

            return View(model);
        }
    }
}
