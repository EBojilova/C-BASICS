using System;

class Employee
{
    static void Main()
    {
        string firstName = "Georgi";
        string lastName = "Georgiev";
        byte Age = 34;
        char Gender = 'm';
        long IDNumber = 8212136929;
        int EmployeeNumber = 27560220;
        Console.WriteLine("The name of employer is: {0} {1}, he is {2} years old, his sex is {3}, his ID Number is {4} and his employee number is {5}",
                            firstName, lastName, Age, Gender, IDNumber, EmployeeNumber);
    }
}
