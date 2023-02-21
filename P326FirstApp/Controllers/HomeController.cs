using Microsoft.AspNetCore.Mvc;
using P326FirstApp.ViewModels;
using P326FirstApp.Models;

namespace P326FirstApp.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index(int id,string name)
        //{
        //    return Content($"id=>>{id}  name=>>{name}");
        //}
        public IActionResult Index()
        {
            ViewData["Name"] = "Ismayil";
            ViewBag.Surname = "Zeynalov";
            TempData["Age"] = 20;
            //return File("~/img/dog.jpg", "image/jpg");
            //var students = GetStudents();
            //var groups = GetGroups();
            //HomeVM homeVM = new HomeVM();
            //homeVM.Students = students;
            //homeVM.Groups = groups;
            return RedirectToAction("About");
        }
        public IActionResult About()
        {
            return View();
        }

        private  List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Stu1", Surname = "Sru1" });
            students.Add(new Student() { Id = 2, Name = "Stu2", Surname = "Sru2" });
            students.Add(new Student() { Id = 3, Name = "Stu3", Surname = "Sru3" });
            return students;

        }
        private List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, Name = "Gru1" });
            groups.Add(new Group() { Id = 2, Name = "Gru2" });
            groups.Add(new Group() { Id = 3, Name = "Gru3"});
            return groups;

        }
    }
}
