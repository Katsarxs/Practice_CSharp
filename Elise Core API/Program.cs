using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace Elise_Core_API
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = FirstAmazonExercise.GetCoveredHouseCount();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<TaxCalculator>();

            serviceCollection.AddSingleton<ICountryTaxAble, GreeceTaxable>();

            serviceCollection.AddSingleton<ITaxHandler, ConsoleHandler>();

            serviceCollection.AddSingleton<ITaxHandler, FileHandler>();

            var provider = serviceCollection.BuildServiceProvider();

            var taxCalculator = provider.GetRequiredService<TaxCalculator>();

            var tax = await taxCalculator.GetFullTaxAsync();

            var service1 = provider.GetRequiredService<TaxCalculator>();

            var service2 = provider.GetRequiredService<TaxCalculator>();

            var check = service1 == service2;
        }
    }
    public class TaxCalculator
    {

        public TaxCalculator(ICountryTaxAble countryTaxAble, IEnumerable<ITaxHandler> handlers)
        {
            CountryTaxAble = countryTaxAble ?? throw new ArgumentNullException(nameof(countryTaxAble));
            Handlers = handlers ?? Enumerable.Empty<ITaxHandler>();
        }

        public ICountryTaxAble CountryTaxAble { get; }
        public IEnumerable<ITaxHandler> Handlers { get; }

        public async Task<string> GetFullTaxAsync()
        {
            var tax = CountryTaxAble.GetTax().ToString();

            foreach (var handler in Handlers)
            {
                await handler.HandleTax(tax);
            }

            return tax;
        }
    }

    public class ConsoleHandler : ITaxHandler
    {
        public Task HandleTax(string tax)
        {
            Console.WriteLine(tax);

            return Task.CompletedTask;
        }
    }

    public class FileHandler : ITaxHandler
    {
        public Task HandleTax(string tax)
        {
            return File.WriteAllTextAsync(@$"C:\Users\User\Videos\Captures\aaaa.txt", tax);
        }
    }

    public interface ITaxHandler
    {
        Task HandleTax(string tax);
    }
    public interface ICountryTaxAble
    {
        string Name { get; }

        decimal GetTax();
        string GetFileName();
    }

    public class GreeceTaxable : ICountryTaxAble
    {
        public string Name { get; } = "Greece";

        public string GetFileName()
        {
            return "jadfbeb";
        }

        public decimal GetTax()
        {
            return 24;
        }


    }
}