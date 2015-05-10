using System;

    class BitShooter
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int shootCenter = int.Parse(input[0]);
                int shootSize = int.Parse(input[1]);
                int shootStart=((shootCenter-shootSize/2) >= 0 ? shootCenter-shootSize/2 : 0);
                int shootEnd= ((shootCenter+shootSize/2) <= 63 ? shootCenter+shootSize/2 : 63);
                for (int j = shootStart; j <= shootEnd; j++)
                {
                    number &= ~(1ul << j);
                }
                //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
            }
            byte countRigth = 0;
            byte countLeft = 0;
            ulong numberCheck;
            for (int i = 0; i < 64; i++)
            {
                numberCheck = number >> i & 1ul;
                if (i<32 && numberCheck==1)
                {
                    countRigth++;
                }
                else if (i >= 32 && numberCheck == 1)
                {
                    countLeft++;
                }
            }
            Console.WriteLine("left: {0}", countLeft);
            Console.WriteLine("right: {0}", countRigth);
        }
    }
