using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 0 , Name = "Information Technology"});
            list.Add(new Department { Id = 1, Name = "Enginering" });
            return View(list);
        }
    }
}
