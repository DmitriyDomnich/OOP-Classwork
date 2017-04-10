using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    struct City
    {
        public string Name;
        public int Populations;
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<City> cities = new List<City>();
            string city = "Kharkiv=22222,Kiev=33333,Las Vegas=44444";            
            string[] x = city.Split(',');

            foreach (var item in x)
            {
                string[] ii = item.Split('=');
                cities.Add(new City() { Name = x[0], Populations = int.Parse(x[1]) });
            }

            int MaxIndex = 0;
            int maxSizeOfIndex = 0;

            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].Populations > cities[MaxIndex].Populations)
                    MaxIndex = i;
                if (cities[i].Name.Length > cities[maxSizeOfIndex].Name.Length)
                    maxSizeOfIndex = i;
            }
            Console.WriteLine($"{cities[maxSizeOfIndex]} - {cities[MaxIndex]}");
        }
    }
}
