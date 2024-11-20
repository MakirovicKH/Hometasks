using Microsoft.AspNetCore.Mvc;
using MVCPROJECTION1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPROJECTION1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            var teachers = new List<Teacher>
        {
            new Teacher { Id = 1, Name = "Narmin", Surname = "Shivakhanova", Subject = "BackEnd Nezeriyye" },
            new Teacher { Id = 2, Name = "Vilayat", Surname = "Aliyev", Subject = "BackEnd Lab" }
        };
            return View(teachers);
        }
    }

}
