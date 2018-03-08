using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    class Program
    {
        // we declare constants as of what we want to use in our password
        private const string UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Numbers = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()_+-{}?/>[]<";
        private const string CombinedCharacters =
            UpperLetters + LowerLetters + Numbers + SpecialCharacters;

        // we create the variable random outside the main method to have access to it throughout the class
        private static Random random = new Random();
        
        // lets start generating the password!!!
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();

            for (int i = 0; i <= 2; i++)
            {
                char uppercaseLetter = GenerateChar(UpperLetters);
                InsertAtRandomPosition(password, uppercaseLetter);
            }
            for (int i = 0; i <= 2; i++)
            {
                char lowercaseLetter = GenerateChar(LowerLetters);
                InsertAtRandomPosition(password, lowercaseLetter);
            }
            for (int i = 0; i <= 2; i++)
            {
                char number = GenerateChar(Numbers);
                InsertAtRandomPosition(password, number);
            }
            for (int i = 0; i <= 2; i++)
            {
                char specialChars = GenerateChar(SpecialCharacters);
                InsertAtRandomPosition(password, specialChars);
            }
            for (int i = 0; i <= 7; i++)
            {
                char rdmPicked = GenerateChar(CombinedCharacters);
                InsertAtRandomPosition(password, rdmPicked);
            }

            Console.WriteLine(password);

        }
        // this method assigns the value a random position inside the password
        private static void InsertAtRandomPosition(StringBuilder password, char c)
        {
            int randomPosition = random.Next(password.Length + 1);
            password.Insert(randomPosition, c);
        }
        // this method generates a random char with with the variable we created outside the main method
        private static char GenerateChar(string availableChars)
        {
            int randomIndex = random.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}
