using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GmailStatsClient.Models;
using Newtonsoft.Json;
using GmailStatsClient.Data;

namespace GmailStatsClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            return View();
        }

        public JsonResult GetChartData()
        {
            var data = new List<MailsData>()
            {
                new MailsData() {Part = PartOfDay.Afternoon, Amount = 30},
                new MailsData() {Part = PartOfDay.Morning, Amount = 20},
                new MailsData() {Part = PartOfDay.Evening, Amount = 10},
            };

            var dataforchart = data.Select(x => new { Part = x.Part, Amount = x.Amount });

            return Json(dataforchart);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
