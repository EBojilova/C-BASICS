using System;

class Program
{
    class Employee
    {
        public DateTime HiringDate { get; set; }
    }

    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now);

        Employee employee = new Employee() { HiringDate = now };
        Console.WriteLine(employee.HiringDate);
    }
}