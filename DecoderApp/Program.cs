using System;

namespace DecoderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RSAEncrypt rsa = new RSAEncrypt();

            Console.WriteLine("Chose your option: ");
            Console.WriteLine("1 - Vigenere Cipher Encrypt ");
            Console.WriteLine("2 - Vigenere Cipher Decrypt ");
            Console.WriteLine("3 - ROT13 Decrypt ");
            Console.WriteLine("4 - Caesar Cipher Decrypt ");

            int result = int.Parse(Console.ReadLine());

            new ChoiceManager(result);

            Console.ReadKey();
        }
    }
}
