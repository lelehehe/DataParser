using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists("data.json"));
            var result = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText("data.json"));
            Console.WriteLine("hello");
             
        }
    }


    public class Rootobject
    {
        public DateTime serverUtcTime { get; set; }
        public string token { get; set; }
        public int status { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public int totalRows { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string[] ships { get; set; }
        public string[] businessRegions { get; set; }
        public string company { get; set; }
        public string defaultImageUrl { get; set; }
        public string[] countries { get; set; }
        public string[] departureMonths { get; set; }
        public string[] destinationRegions { get; set; }
        public DateTime endDate { get; set; }
        public string endLocation { get; set; }
        public bool hasVirtuosoVoyages { get; set; }
        public string[] locations { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public string startLocation { get; set; }
        public string travelLength { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public bool hasPromotions { get; set; }
        public bool hasVirtuosoBenefits { get; set; }
    }


}
