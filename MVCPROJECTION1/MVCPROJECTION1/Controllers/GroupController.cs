using Microsoft.AspNetCore.Mvc;
using MVCPROJECTION1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPROJECTION1.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            var groups = new List<Group>
        {
            new Group { Id = 1, Name = "Group AB205", Description = "First group" },
            new Group { Id = 2, Name = "Group AB108", Description = "Second group" }
        };
            return View(groups);
        }
    }

}
