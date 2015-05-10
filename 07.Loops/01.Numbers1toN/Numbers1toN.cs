using System;

class Numbers1toN
{
    static void Main()
    {
        int n = new int();
        Console.Write("n: ");
        string nStr =Console.ReadLine();
        if (!int.TryParse(nStr, out n))
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
            
        }
    }
}
/* while (counter <= number)
            {
                Console.WriteLine("{0}", counter);
                counter++;
            }*?
