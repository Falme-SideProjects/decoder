using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderApp
{
    public class CaesarDecrypt : ICript
    {
        private int numberDifference = 13;
        private string result = "";
        private string message;

        public string GetResult()
        {
            return result;
        }

        public void InputValues()
        {
            Console.WriteLine("Please Insert the encripted Message:");
            message = Console.ReadLine().ToUpper();

            Console.WriteLine("Please Insert the Diff number:");
            numberDifference = int.Parse(Console.ReadLine());
        }

        public void ProcessData()
        {
            for (int a=0; a< message.Length; a++)
            {
                if(!message[a].Equals(' '))
                {
                    int numberLetter = Encoding.Default.GetBytes(message[a].ToString())[0];

                    numberLetter -= numberDifference;
                    if (numberLetter < 65) numberLetter += 26;

                    result += char.ConvertFromUtf32(numberLetter);
                } else
                {
                    result += " ";
                }
            }
        }


    }
}
