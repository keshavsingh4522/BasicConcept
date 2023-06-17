using System;

public static void Display(Employee emp)
{
    Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}");
}

public static void Main()
{
    Person per = new Employee();
    per.FirstName = "Steve";
    per.LastName = "Jobs";

    //Cannot convert from Person to Employee implicitly
    Display(per);//error 

    Display(per as Employee);//valid, explicit conversion

    Employee emp = new Employee();
    emp.FirstName = "Abdul";
    emp.LastName = "Kalam";
    Display(emp);//valid
}

