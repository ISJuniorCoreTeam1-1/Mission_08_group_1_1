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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ViewTasks()
        {

            //Get data from the models
            var tasks = TaskContext.Tasks //Specify context file and table name
                .Include(x => x.Category) //Include the other table's data
                .OrderBy(x => x.DueDate)
                .ToList();

            return View(tasks);
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
