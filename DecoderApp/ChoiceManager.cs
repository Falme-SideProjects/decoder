using System;
using System.Collections.Generic;
using System.Text;

namespace DecoderApp
{
    class ChoiceManager
    {
        ICript cript;

        public ChoiceManager(int _choice)
        {
            switch(_choice)
            {
                case 1:
                    cript = new VigenereCript();
                    break;
                case 2:
                    cript = new VigenereDecript();
                    break;
                case 3:
                    cript = new Rot13Decrypt();
                    break;
                case 4:
                    cript = new CaesarDecrypt();
                    break;
            }

            RunCript();
        }

        public void RunCript()
        {
            cript.InputValues();
            cript.ProcessData();
            
            Console.WriteLine(cript.GetResult());
        }
    }
}
