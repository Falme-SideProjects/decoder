using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderApp
{
    public class VigenereCript : ICript
    {
        private string original;
        private string key;
        private string result;

        public void InputValues()
        {
            Console.WriteLine("Please Insert the original Message:");
            original = Console.ReadLine().ToLower();


            Console.WriteLine("Please Insert the key to Encode:");
            key = Console.ReadLine().ToLower();
        }

        public void ProcessData()
        {
            int baseNumber = ((int)('a'));
            int maxNumber = ((int)('z'));
            int lengthNumber = 26;

            StringBuilder sb = new StringBuilder();

            for(int a=0; a<original.Length; a++)
            {
                int numberdiff = ((int)original[a] + ((int)key[a]) - baseNumber);
                numberdiff = (numberdiff > maxNumber ? (numberdiff - lengthNumber) : numberdiff);
                sb.Append((char)numberdiff);
            }

            result = sb.ToString();

        }
        public string GetResult()
        {
            return result;
        }
    }
}
