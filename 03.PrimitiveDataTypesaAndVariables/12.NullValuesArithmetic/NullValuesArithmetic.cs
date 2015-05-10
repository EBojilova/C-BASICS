using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? null1 = null;
            double? null2 = null;
            Console.WriteLine("Integer null is: {0}", null1 );
            Console.WriteLine("Double null is: {0}", null2);
            Console.WriteLine(null1+5);
            Console.WriteLine(null2+10);
        }
    }

