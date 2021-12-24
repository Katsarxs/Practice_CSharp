using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;

namespace PasswordGenerator
{
    class Program
    {
        public int Value = 0;
        static void Main(string[] args)
        {
            var generator = PasswordGenerator.Singleton;

            var passwords = generator.GeneratePasswords(8, 5);

        }
    }
}