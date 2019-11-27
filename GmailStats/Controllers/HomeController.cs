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
        public IActionResult AllStats()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("Morning", 50));
            dataPoints.Add(new DataPoint("Afternoon", 30));
            dataPoints.Add(new DataPoint("Evening", 20));
           

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
    }
}
