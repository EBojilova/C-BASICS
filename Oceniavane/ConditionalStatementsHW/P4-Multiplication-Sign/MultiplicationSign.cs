using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0;
            //input validation
            bool convert = false;
            while (!convert)
            {
                Console.Write("Enter a: ");
                convert = double.TryParse(Console.ReadLine(), out a);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }

            convert = false;
            while (!convert)
            {
                Console.Write("Enter b: ");
                convert = double.TryParse(Console.ReadLine(), out b);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }

            convert = false;
            while (!convert)
            {
                Console.Write("Enter c: ");
                convert = double.TryParse(Console.ReadLine(), out c);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }
            //end of input validation
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (a > 0)
                {
                    if (b > 0)
                    {
                        if (c > 0)
                        {
                            Console.WriteLine("+");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                    else //b<0
                    {
                        if(c>0)
                        {
                            Console.WriteLine("-");
                        }
                        else //c<0
                        {
                            Console.WriteLine("+");
                        }
                    }
                }
                else //a<0
                {
                    if(b>0)
                    {
                        if(c>0)
                        {
                            Console.WriteLine("-");
                        }
                        else //c<0
                        {
                            Console.WriteLine("+");
                        }
                    }
                    else //b<0
                    {
                        if(c>0)
                        {
                            Console.WriteLine("+");
                        }
                        else //c<0
                        {
                            Console.WriteLine("-");
                        }
                    }
                }
            }
        }
    }
}
