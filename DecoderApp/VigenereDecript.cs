using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderApp
{
    public class VigenereDecript : ICript
    {
        private string hash;
        private string key;
        private string result;

        public void InputValues()
        {
            Console.WriteLine("Please Insert the encripted Message:");
            hash = Console.ReadLine().ToLower();

            Console.WriteLine("Please Insert the key to Decode:");
            key = Console.ReadLine().ToLower();
        }

        public void ProcessData()
        {
            int baseNumber = ((int)('a'));
            int maxNumber = ((int)('z'));
            int lengthNumber = 26;

            StringBuilder sb = new StringBuilder();

            for(int a=0; a< hash.Length; a++)
            {
                if((int)key[a] <= (int)hash[a])
                {
                    int r = baseNumber + Math.Abs((int)key[a] - (int)hash[a]);

                    r = (r > maxNumber ? (r - lengthNumber) : r);
                    sb.Append((char)r);
                } else
                {
                    int i = 0;
                    char c = key[a];
                    while(c != hash[a])
                    {
                        int x = (int)c + 1;
                        if (x > maxNumber) x = baseNumber;
                        c = (char)x;
                        i++;
                    }

                    sb.Append((char)(i+baseNumber));
                }
            }

            result = sb.ToString();

        }
        public string GetResult()
        {
            return result;
        }
    }
}
