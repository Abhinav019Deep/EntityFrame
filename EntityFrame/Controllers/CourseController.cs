using BussinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.DiaSymReader;

namespace EntityFrame.Controllers
{
    public class CourseController : Controller
    {
        BussinessAccessLayer.BAL bal = new BussinessAccessLayer.BAL();

        public IActionResult Index()
        {
            var list =  bal.GetAllCourses();

            //if (list.Count() > 0)
            //{
            //    return View(list);
            //}
            //else
            //{
            //    ViewBag.Msg = "No Records";
            //    return View();
            //}
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            bal.AddCourse(course);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var obj = bal.GetCourseById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(int id, Course course)
        {
            bal.DeleteCourse(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var obj = bal.GetCourseById(id);
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            var obj = bal.GetCourseById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(int id, Course course)
        {
            bal.EditCourse(id, course);
            return RedirectToAction("Index");
        }
    }
}

