using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        #region Private Members

        /// <summary>
        /// The available digits
        /// </summary>
        private readonly List<string> _Numbers = new() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        /// <summary>
        /// The available lower case letters
        /// </summary>
        private readonly List<string> _LowerLetters = new() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        /// <summary>
        /// The available symbols
        /// </summary>
        private readonly List<string> _Symbols = new() { "!", "#", "$", "@", "%" };

        /// <summary>
        /// The avilable upper case letters 
        /// </summary>
        private List<string> _UpperLetters => _LowerLetters.Select(x => x.ToUpper()).ToList();

        /// <summary>
        /// The available characters
        /// </summary>
        private List<string> _AllCharacters => _Numbers.Concat(_LowerLetters).Concat(_Symbols).Concat(_UpperLetters).ToList();

        /// <summary>
        /// The random generator
        /// </summary>
        private readonly Random mRandomGenerator = new();

        private static readonly Lazy<PasswordGenerator> _PasswordGenerator = new(() => new PasswordGenerator());

        #endregion

        #region Public Properties

        /// <summary>
        /// The minimum password length
        /// </summary>
        public static int MinimumPasswordLength { get; } = 4;

        public static PasswordGenerator Singleton => _PasswordGenerator.Value;

        #endregion
        #region Constructors

        protected PasswordGenerator()
        {

        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Returns randon passwords equal to the <paramref name="numberOfPasswords"/> with length equal to the <paramref name="passwordLength"/>
        /// </summary>
        /// <param name="passwordLength">The password length</param>
        /// <param name="numberOfPasswords">The number of passwords</param>
        /// <returns></returns>
        public IEnumerable<string> GeneratePasswords(int passwordLength, int numberOfPasswords)
        {

            if (passwordLength < MinimumPasswordLength)
                passwordLength = MinimumPasswordLength;


            List<string> passwords = new();



            for (int index = 0; index < numberOfPasswords; index++)
            {
                var passwordCharacters = new List<string>();

                var randomDigit = GetRandomCharacter(_Numbers);

                passwordCharacters.Add(randomDigit);

                var randomUpperLetter = GetRandomCharacter(_UpperLetters);

                passwordCharacters.Add(randomUpperLetter);

                var randomLowerLetter = GetRandomCharacter(_LowerLetters);

                passwordCharacters.Add(randomLowerLetter);

                var randomSymbol = GetRandomCharacter(_UpperLetters);

                passwordCharacters.Add(randomSymbol);


                if (passwordLength > MinimumPasswordLength)
                {
                    for (var i = 0; i < passwordLength - 4; i++)
                    {
                        var randomAllCharacter = GetRandomCharacter(_AllCharacters);

                        passwordCharacters.Add(randomAllCharacter);
                    }
                }

                var pass = string.Empty;

                for (var i = 0; i < passwordLength; i++)
                {
                    var randomPasswordCharacter = GetRandomCharacter(passwordCharacters);

                    pass += randomPasswordCharacter;

                    passwordCharacters.Remove(randomPasswordCharacter);
                }

                passwords.Add(pass);
            }


            return passwords;
        }

        #endregion

        #region Private Methods

        private string GetRandomCharacter(IEnumerable<string> values)
            => values.ElementAt(GetRandomIndex(values));
        private int GetRandomIndex(IEnumerable<object> values)
            => mRandomGenerator.Next(0, values.Count());

        #endregion
    }

}
