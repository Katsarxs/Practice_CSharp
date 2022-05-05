using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;

namespace CarModelOrganizer
{
    class Program
    {
        public static List<object> ServiceCollection = new List<object>();
        static void Main(string[] args)
        {
            var singleInstance = new GermanyDetails();

        }

        public interface ICountryTaxable
        {
            string CountryCode { get; }

            decimal GetTax();
        }

        public class GermanyDetails : ICountryTaxable
        {
            public string CountryCode => "GE";

            public decimal GetTax()
                => 1;
        }
        public decimal GetTax(string country)
        {
            var supportedCountryCode = ServiceCollection.OfType<ICountryTaxable>().ToList();

            var selectedCountry = supportedCountryCode.FirstOrDefault(x => x.CountryCode == country);

            if (selectedCountry == null)
                return 0;

            return selectedCountry.GetTax();
        }
    }


    public interface INameable
    {
        string Name { get; }


        decimal GetSalary();
    }

    public class Claim
    {
        public string Name { get; set; }

        public string Values { get; set; }
    }

    public abstract class User : INameable
    {
        protected List<Claim> Claims = new();

        public string Name { get; set; }

        public string Email { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }

        public abstract string GetTitle();

        public abstract decimal GetSalary();
    }

    public class Employee : User
    {
        public override decimal GetSalary()
        {
            Claims.RemoveAll(x => x.Values == "Test");

            return 0;
        }

        public override string GetTitle()
            => "Employee";
    }

    public class Admin : User
    {

        public override string GetTitle()
            => null;

        public override decimal GetSalary()
            => 10;
    }
}