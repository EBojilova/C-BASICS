using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Digit_as_Word
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            byte input;
            bool convert = false;

            convert = byte.TryParse(Console.ReadLine(), out input) && input>0 && input<=9;
            if(!convert)
            {
                Console.WriteLine("not a digit");
            }
            else
            {
                switch(input)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;

                }
            }
        }
    }
}
