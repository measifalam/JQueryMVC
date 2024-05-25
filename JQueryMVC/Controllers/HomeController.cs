using JQueryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JQueryMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Add(int num1,int num2)
        {
            

            return num1+num2;
        }


        public Calculate CalculateNumber(int num1,int num2, string msg) 
        { 
            Calculate calculate = new Calculate();
            calculate.Add=num1 + num2;
            calculate.Sub = num1 - num2;
            calculate.Mul = num1 * num2;
            calculate.Divide = num1 / num2;

            return calculate;
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
