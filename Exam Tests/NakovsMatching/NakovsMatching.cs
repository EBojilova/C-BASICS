using System;

class NakovsMatching
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        string leftA = "";
        bool mathchesNotFound = true;
        for (int i = 0; i < a.Length - 1; i++)
        {
            leftA += a[i];
            string rightA = a.Substring(i + 1);
            int weightAleft = StringWeight(leftA);
            int weightAright = StringWeight(a) - weightAleft;
            string leftB = "";
            for (int j = 0; j < b.Length - 1; j++)
            {
                leftB += b[j];
                string rightB = b.Substring(j + 1);
                int weightBleft = StringWeight(leftB);
                int weightBright = StringWeight(b) - weightBleft;
                //•	nakovs = w(aLeft) * w(bRight) - w(aRight) * w(bLeft)
                int nakovs = Math.Abs(weightAleft * weightBright - weightAright * weightBleft);
                if (nakovs <= d)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", leftA, rightA, leftB, rightB, nakovs);
                    mathchesNotFound = false;
                }
            }
        }
        if (mathchesNotFound)
        {
            Console.WriteLine("No");
        }
    }

    private static int StringWeight(string word)
    {
        int weight = 0;
        for (int i = 0; i < word.Length; i++)
        {
            weight += word[i];
        }
        return weight;
    }
}
