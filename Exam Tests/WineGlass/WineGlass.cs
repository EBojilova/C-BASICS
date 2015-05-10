using System;
    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                string emptySpace= new string('.', i);
                string wine=new string('*', n-2*i-2);
                Console.WriteLine("{0}\\{1}/{0}",emptySpace,wine);
            }
            int baseRows;
            if (n<12)
            {
                baseRows = 1;
            }
            else
            {
                baseRows = 2;
            }
            for (int i = 0; i < n/2-baseRows; i++)
			{
                Console.WriteLine("{0}||{0}", new string('.',n/2-1));
			}
            for (int i = 0; i < baseRows; i++)
            {
                string glassBase = new string('-', n);
                Console.WriteLine(glassBase);
            }
            
        }
    }
