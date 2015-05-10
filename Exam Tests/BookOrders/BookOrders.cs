using System;

class BookOrders
{
    static void Main(string[] args)
    {
        int orders = int.Parse(Console.ReadLine());
        decimal bookPrice = new decimal();
        int numOfPackets = new int();
        int booksPerPacket = new int();
        int allBooks = 0;
        decimal totalPrice = 0;
        for (int i = 0; i < orders; i++)
        {
            numOfPackets = int.Parse(Console.ReadLine());
            booksPerPacket = int.Parse(Console.ReadLine());
            bookPrice = decimal.Parse(Console.ReadLine());
            //(10-19 packets = 5% discount, 20-29 = 6%, 30-39 = 7%, ..., 100-109 = 14%, 110 or more-15%)
            if (numOfPackets>=10 && numOfPackets < 110)
            {
                bookPrice *= (100m - numOfPackets / 10 - 4) / 100;
            }
            if (numOfPackets>= 110)
            {
                bookPrice *= 0.85m;
            }
            allBooks += numOfPackets * booksPerPacket;
            totalPrice += bookPrice * numOfPackets * booksPerPacket;
        }
        Console.WriteLine(allBooks);
        Console.WriteLine("{0:F2}", totalPrice);
    }
}
