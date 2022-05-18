using System;
using System.IO;

namespace ChuckNorris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomPhrase;
            randomPhrase = GetRandomFromFile("chuck.txt");
            
            Console.WriteLine(randomPhrase);

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\maksi\samples\chuck.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }


    }
}
