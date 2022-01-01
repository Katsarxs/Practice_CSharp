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
        var input = new List<CarModel>()
            {
                new()
                {
                    Company = "Toyota",
                    Model = "Yaris",
                    Price = 14000
                },
                new()
                {
                    Company = "Opel",
                    Model = "Corsa",
                    Price = 16000
                },
                new()
                {
                    Company = "Toyota",
                    Model = "Aygo",
                    Price = 11000
                },
                new()
                {
                    Company = "Toyota",
                    Model = "Corolla",
                    Price = 17000
                },
                new()
                {
                    Company = "Fiat",
                    Model = "Panda",
                    Price = 12000
                },
                new()
                {
                    Company = "Opel",
                    Model = "Corsa",
                    Price = 15500
                },
                new()
                {
                    Company = "Toyota",
                    Model = "Yaris",
                    Price = 17000
                },
                new()
                {
                    Company = "Opel",
                    Model = "Astra",
                    Price = 19000
                },
                new()
                {
                    Company = "Fiat",
                    Model = "Tipo",
                    Price = 12000
                }
            };
    }
}