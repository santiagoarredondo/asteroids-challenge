using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(DateTime startDate, DateTime endDate)
        {
            DateTime defaultDate = new DateTime();
            if (startDate.Equals(defaultDate)&&endDate.Equals(defaultDate)){
                startDate = Utils.getDefaultDate();
                endDate = startDate;
            }else if (startDate.Equals(defaultDate)){
                startDate = endDate;
            }else {
                endDate = startDate;
            }
            
            Console.WriteLine();
            string link = @"https://api.nasa.gov/neo/rest/v1/feed?start_date=" + startDate.ToString("yyyy-MM-dd") + @"&end_date=" + endDate.ToString("yyyy-MM-dd") + @"&api_key=pJiODzcpV9OaqN1Hhci1YT8m7wDqo36HzwwyeXsa";
            //string link = Utils.link;
            Console.WriteLine($"accesing to: {link}");
            var webClient = new WebClient();
            var json = webClient.DownloadString(link);
            //Rootobject c1 = JsonConvert.DeserializeObject<Rootobject>(json);
            List<Class1.DateInformation> tableInfo = new List<Class1.DateInformation>();
            Class1.Rootobject jsonObject = JsonConvert.DeserializeObject<Class1.Rootobject>(json);
            Dictionary<string,Class1.DateInformation[]> nearEarthObjects = jsonObject.near_earth_objects;
            foreach (KeyValuePair<string, Class1.DateInformation[]> nearEarthObjectDateInformation in nearEarthObjects)
            {
                foreach (Class1.DateInformation dateInfo in nearEarthObjectDateInformation.Value)
                {
                    tableInfo.Add(dateInfo);
                }
            }
            return View(tableInfo);
        }
        
        [HttpGet]
        public IActionResult Privacy()
        {
            //string link = @"https://api.nasa.gov/neo/rest/v1/feed?start_date=" + Utils.DateToString(startDate) + @"&end_date=" + Utils.DateToString(endDate) + @"&api_key=aqSXasG5NLdhh7TBbIeKXJT3VhrkNwD3PSJDrMba";
            string link = Utils.link;
            Console.WriteLine($"accesing to: {link}");
            var webClient = new WebClient();
            var json = webClient.DownloadString(link);
            //Rootobject c1 = JsonConvert.DeserializeObject<Rootobject>(json);
            List<Class1.DateInformation> tableInfo = new List<Class1.DateInformation>();
            Class1.Rootobject jsonObject = JsonConvert.DeserializeObject<Class1.Rootobject>(json);
            Dictionary<string, Class1.DateInformation[]> nearEarthObjects = jsonObject.near_earth_objects;
            foreach (KeyValuePair<string, Class1.DateInformation[]> nearEarthObjectDateInformation in nearEarthObjects)
            {
                foreach (Class1.DateInformation dateInfo in nearEarthObjectDateInformation.Value)
                {
                    tableInfo.Add(dateInfo);
                }
            }
            return View(tableInfo);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
