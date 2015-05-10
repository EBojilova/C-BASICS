using System;

    class Triangle
    {
        static void Main()
        {
            double xA, yA, xB, yB, xC, yC = new double();
            Console.Write("xA: ");
            string xAstr = Console.ReadLine();
            if (double.TryParse(xAstr, out xA)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            Console.Write("yA: ");
            string yAstr = Console.ReadLine();
            if (double.TryParse(yAstr, out yA)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            Console.Write("xB: ");
            string xBstr = Console.ReadLine();
            if (double.TryParse(xBstr, out xB)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            Console.Write("yB: ");
            string yBstr = Console.ReadLine();
            if (double.TryParse(yBstr, out yB)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            Console.Write("xC: ");
            string xCstr = Console.ReadLine();
            if (double.TryParse(xCstr, out xC)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            Console.Write("yC: ");
            string yCstr = Console.ReadLine();
            if (double.TryParse(yCstr, out yC)) ;
            else
            {
                Console.WriteLine("out of range");
            }
            double ac=Math.Sqrt((xA-xC)*(xA-xC)+(yA-yC)*(yA-yC));
            double ab = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
            double cb = Math.Sqrt((xC - xB) * (xC - xB) + (yC - yB) * (yC - yB));
            if ((ac+ab)>cb & ab+cb>ac & cb+ac>ab)
            {
                Console.WriteLine("Yes");
                double p= (ac+cb+ab)/2;
                double area = Math.Sqrt(p * (p - ac) * (p - ab) * (p - cb));
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", ab);
            }
        }
    }

