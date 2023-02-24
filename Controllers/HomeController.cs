using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_08_group_1_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_08_group_1_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TaskContext TaskContext { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskContext name)
        {
            _logger = logger;
            TaskContext = name;
        }

        [HttpGet]
        public IActionResult ViewTasks() //Where all the tasks are in thier quadrants
        {

            //Get data from the models
            var tasks = TaskContext.Tasks //Specify context file and table name
                .Include(x => x.Category) //Include the other table's data
                .OrderBy(x => x.DueDate)
                .ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult AddTodo()
        {
            ViewBag.Categories = TaskContext.Category.ToList(); //Pass the categories in as a list to the viewbag

            return ("AddTodo", new Tasks());
        }

        [HttpPost]
        public IActionResult AddTodo(Tasks ar)
        {
            if (ModelState.IsValid)
            {
                TaskContext.Add(ar);
                TaskContext.SaveChanges();

                var tasks = TaskContext.Tasks
                    .Include(x => x.Category) //Include the other table's data
                    .OrderBy(x => x.DueDate)
                    .ToList();
                return ("ViewTasks", tasks);
            }

            ViewBag.Categories = TaskContext.Categories.ToList();

            return ("AddTodo", ar);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
