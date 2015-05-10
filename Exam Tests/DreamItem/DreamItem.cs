using System;

class DreamItem
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split('\\');
        int daysInMonth;
        switch (input[0])
        {
            // "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov" or "Dec".
            case "Feb":
                daysInMonth = 28;
                break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                daysInMonth = 30;
                break;
            default:
                daysInMonth = 31;
                break;
        }
        decimal moneyHour = decimal.Parse(input[1]);
        int hoursDaily = int.Parse(input[2]);
        decimal priceItem = decimal.Parse(input[3]);
        decimal a = (daysInMonth-10) * hoursDaily * moneyHour > 700M ? 1.1M : 1M;
        decimal check = (daysInMonth-10) * hoursDaily * moneyHour * a - priceItem;
        if (check >= 0)
        {
            Console.WriteLine("Money left = {0:F2} leva.", check);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(check));
        }
    }
}

