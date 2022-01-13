using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;

namespace CarModelOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

        }
        public static void Test()
        {
            var input = new List<CarModel>()
            {
                new()
                {
                    CompanyName = "Toyota",
                    Model = "Yaris",
                    Price = 14000
                },
                new()
                {
                    CompanyName = "Opel",
                    Model = "Corsa",
                    Price = 16000
                },
                new()
                {
                    CompanyName = "Toyota",
                    Model = "Aygo",
                    Price = 11000
                },
                new()
                {
                    CompanyName = "Toyota",
                    Model = "Corolla",
                    Price = 17000
                },
                new()
                {
                    CompanyName = "Fiat",
                    Model = "Panda",
                    Price = 12000
                },
                new()
                {
                    CompanyName = "Opel",
                    Model = "Corsa",
                    Price = 15500
                },
                new()
                {
                    CompanyName = "Toyota",
                    Model = "Yaris",
                    Price = 17000
                },
                new()
                {
                    CompanyName = "Opel",
                    Model = "Astra",
                    Price = 19000
                },
                new()
                {
                    CompanyName = "Fiat",
                    Model = "Tipo",
                    Price = 12000
                }
            };

            input.GroupBy(x => x.CompanyName)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} : {x.Count()} [{x.Select(x => x.Model).Distinct().Aggregate((leftElement, rightElement) => leftElement + ", " + rightElement)}]"));

            var companies = new HashSet<string>();

            foreach (var company in input)
            {
                companies.Add(company.CompanyName);

            }

            var carsPerCompany = new Dictionary<string, List<CarModel>>();

            foreach (var companyName in companies)
            {
                var companyCars = input.Where(carModel => carModel.CompanyName == companyName).ToList();

                carsPerCompany.Add(companyName, companyCars);
            }




            foreach (var companyName in companies)
            {
                var companyCarModels = carsPerCompany[companyName];

                var t = companyCarModels.Select(x => x.Model).Distinct().Aggregate((leftElement, rightElement) => leftElement + ", " + rightElement);

                Console.WriteLine($"{companyName} : {companyCarModels.Count} [{t}]");
            }

            var breakPoint = "";
        }

        public int Int()
            => 0;

        public decimal Max(List<CarModel> values)
        {
            return values.Max(x => x.Price);  
        }

        public TClass Max<TClass>(List<TClass> values, Func<TClass, int> valueSelector)
        {
            var dict = new Dictionary<TClass, int>();
            foreach (var element in values)
            {
               dict.Add(element,  valueSelector(element));
            }

            return dict.OrderByDescending(x => x.Value).First().Key;
        }
    }
}