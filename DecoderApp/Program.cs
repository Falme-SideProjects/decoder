using System;

namespace DecoderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose your option: ");
            Console.WriteLine("1 - Vigenere Cipher Encrypt ");
            Console.WriteLine("2 - Vigenere Cipher Decrypt ");

            int result = int.Parse(Console.ReadLine());

            new ChoiceManager(result);

            Console.ReadKey();
        }
    }
}
