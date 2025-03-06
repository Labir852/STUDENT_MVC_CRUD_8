using Microsoft.AspNetCore.Mvc;
using STUDENT_MVC_CRUD_8.Web.Data;
using STUDENT_MVC_CRUD_8.Web.Models;
namespace STUDENT_MVC_CRUD_8.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
