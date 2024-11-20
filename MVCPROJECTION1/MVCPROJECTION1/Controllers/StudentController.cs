using Microsoft.AspNetCore.Mvc;
using MVCPROJECTION1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPROJECTION1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "Mahir", Surname = "Khalilov", GroupId = 1 },
            new Student { Id = 2, Name = "Yusif", Surname = "Majidov", GroupId = 2 }
        };
            return View(students);
        }
    }

}
