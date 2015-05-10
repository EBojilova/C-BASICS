
/*Problem 12.	* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers
whose sum is 0. Assume that repeating the same subset several times is not a problem.
Examples:
numbers	                result
3  -2  1  1 8	        -2 + 1 + 1 = 0
3 1 -7 35 22	        no zero subset

1 3 -4 -2 -1	        1 + -1 = 0
                        1 + 3 + -4 = 0
                        3 + -2 + -1 = 0

1 1 1 -1 -1	            1 + -1 = 0
                        1 + 1 + -1 + -1 = 0
                        1 + -1 + 1 + -1 = 0

0 0 0 0 0	            0 + 0 + 0 + 0 + 0 = 0*/



using System;

    class SubsetZero
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 integer number n and press key enter");
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" number[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            int sum9 = 0;
            int sum10 = 0;
            int sum11 = 0;
            int sum12 = 0;

            for (int i = 0; i < 4; i++)
            {
                sum0 = array[0] + array[i + 1];
                if (array[0] + array[i + 1] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", array[0], array[i + 1]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                sum1 = array[1] + array[i + 2];
                if (array[1] + array[i + 2] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", array[1], array[i + 2]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                sum2 = array[2] + array[i + 3];
                if (array[2] + array[i + 3] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", array[2], array[i + 3]);
                }
            }
            sum3 = array[3] + array[4];
            if (array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", array[3], array[4]);
            }
            for (int i = 0; i < 3; i++)
            {
                sum4 = array[0] + array[1] + array[i + 2];
                if (array[0] + array[1] + array[i + 2] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", array[0], array[1], array[i + 2]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                sum5 = array[0] + array[2] + array[i + 3];
                if (array[0] + array[2] + array[i + 2] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", array[0], array[2], array[i + 2]);
                }
            }
            sum6 = array[0] + array[3] + array[4];
            if (array[0] + array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", array[0], array[3], array[4]);
            }
            for (int i = 0; i < 2; i++)
            {
                sum7 = array[1] + array[2] + array[i + 3];
                if (array[1] + array[2] + array[i + 3] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", array[1], array[2], array[i + 3]);
                }
            }
            sum8 = array[1] + array[3] + array[4];
            if (array[1] + array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", array[1], array[3], array[4]);
            }
            for (int i = 0; i < 1; i++)
            {
                sum9 = array[0] + array[1] + array[2] + array[i + 3];
                if (array[0] + array[1] + array[2] + array[i + 3] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", array[0], array[1], array[2], array[i + 3]);
                }
            }
            sum10 = array[1] + array[2] + array[3] + array[4];
            if (array[1] + array[2] + array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", array[1], array[2], array[3], array[4]);
            }
            sum11 = array[0] + array[2] + array[3] + array[4];
            if (array[0] + array[2] + array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", array[0], array[2], array[3], array[4]);
            }
            sum12 = array[0] + array[1] + array[2] + array[3] + array[4];
            if (array[0] + array[1] + array[2] + array[3] + array[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", array[0], array[1], array[2], array[3], array[4]);
            }
            if (sum0 != 0 && sum1 != 0 && sum2 != 0 && sum3 != 0 && sum4 != 0 && sum5 != 0 && sum6 != 0 &&
                sum7 != 0 && sum8 != 0 && sum9 != 0 && sum10 != 0 && sum11 != 0 && sum12 != 0)
            {
                Console.WriteLine("No zero subset");
            }
        }
    }

