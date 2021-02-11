using Assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Controllers
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

            List<string> foodPlaceList = new List<string>();

            foreach (FoodPlace fp in FoodPlace.GetFoodPlaces())
            {
                foodPlaceList.Add(string.Format($"#{fp.Rank}: Name: {fp.Name} Favorite: {fp.Fave} Address: {fp.Address} Link: {fp.WebLink}"));
            }
            return View(foodPlaceList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Submissions()
        {
            return View(TempModel.Submissions);
        }

        [HttpGet]
        public IActionResult SubmissionsForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmissionsForm(Submission submission)
        {
            if (ModelState.IsValid)
            {
                TempModel.AddSubmission(submission);
                return View("Submissions", TempModel.Submissions);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
