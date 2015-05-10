using System;

namespace FriendBits
{
    class FriendBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            uint numFriends = 0;
            uint numAlone = 0;
            for (int i = 0, iFriends = 0, iAlone=0; i < 32; i ++)
            {
                uint current = (number >> i) & 1;
                uint prev = (i - 1) >= 0 ? (number >> (i - 1)) & 1 : current; 
                uint next= i+1<32 ? (number >> (i + 1)) & 1 : current;
               if  ((prev == current && i>0) || (current==next && i<31))
                {
                    numFriends |= current << iFriends;
                    iFriends++;
                }
                else 
                {
                    numAlone |= current << iAlone;
                    iAlone++;
                }
            }
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(numFriends);
            Console.WriteLine(numAlone);
        }
    }
}
