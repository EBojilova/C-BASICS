using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DatingSite
{
    class DatingSite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hair color: ");
            string hairColour = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender: ");
            char gender = char.Parse(Console.ReadLine());
            if (gender == 'm' || gender == 'M')
            {
                if (DateTime.Now <= new DateTime(2015, 3, 29))
                {
                    Console.WriteLine("Come let's watch the game");
                }
                Console.WriteLine("I won't date you");
            }
            else if (gender == 'F' || gender == 'f')
            {
                switch (hairColour)
                {
                    case "blonde":
                        {
                            Console.WriteLine("Let,s have fun!");
                            break;
                        }
                    case "red":
                    case "dark":
                        {
                            if (age >= 18 && age < +30)
                            {
                                Console.WriteLine("Let,s have fun!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Let's watch the game!");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Wrong letter");
            }
        }
    }
}
