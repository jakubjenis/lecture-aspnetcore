using System.Linq;
using LectureDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace LectureDemo.Controllers
{
    public class HomeController : Controller
    {
        private StudentRepository _studentRepository;
        private LectureDbContext _lectureDbContext;

        public HomeController(LectureDbContext lectureDbContext)
        {
            _lectureDbContext = lectureDbContext;
            _studentRepository = new StudentRepository();
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetStudents();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _lectureDbContext.Students.Add(student);
                _lectureDbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Detail(int id)
        {
            var student = _studentRepository.GetStudents().First(o => o.Id == id);
            return View(student);
        }

        public IActionResult Json()
        {
            var students = _studentRepository.GetStudents();
            return Json(students);
        }

        public IActionResult Redirect()
        {
            var students = _studentRepository.GetStudents();
            return Redirect("http://google.com");
        }
    }
}
