using HelParkUser.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HelPark.Entities.Concrete;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json;
using JsonConvert = Newtonsoft.Json.JsonConvert;


namespace HelParkUser.API.Controllers
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


            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync("https://api.ibb.gov.tr/ispark/Park");
            }

















            /*var client = new MongoClient("mongodb+srv://emretaskin:emre123@helparkcluster.n2zur.mongodb.net/HelParkDB?retryWrites=true&w=majority");
            var database = client.GetDatabase("HelParkDB");*/






            /* var jsonString = System.IO.File.ReadAllText("IsPark.json");


             var IsPark = JsonConvert.DeserializeObject<List<IsPark>>(jsonString);

             var citiesCollection = database.GetCollection<IsPark>("IsPark");

             foreach (var item in IsPark)
             {
                 var ispark = new IsPark()
                 {
                     parkID = item.parkID,
                     parkName = item.parkName,
                     lat    = item.lat,
                     lng = item.lng,
                     capacity = item.capacity,
                     emptyCapacity = item.emptyCapacity,
                     workHours = item.workHours,
                     parkType = item.parkType,
                     freeTime = item.freeTime,
                     district =  item.district,
                     isOpen = item.isOpen
                 };




                 citiesCollection.InsertOne(ispark); 
             }*/





            /* var collection = database.GetCollection<Test>("Test");

             var test = new Test()
             {
                 _Id = ObjectId.GenerateNewId(),
                 Name = "Emre",
                 Age = 23

             };

             collection.InsertOne(test);  */


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
