using System;

public class StartUp
{
    /// <summary>
    /// Solution of 1-st and 2-nd problems
    ///
    /// 1. Define an interface IPerson with properties for Name and Age.
    /// Define a class Citizen which implements IPerson and has a constructor which takes a string name and an int age.
    ///
    /// 2. Using the code from the previous task, define an interface IIdentifiable with a string property Id 
    /// and an interface IBirthable with a string property Birthdate and implement them in the Citizen class. 
    /// Rewrite the Citizen constructor to accept the new parameters.
    /// </summary>
    public static void Main(string[] args)
    {
		// Code for Judje testing
        var identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
        var birthableInterface = typeof(Citizen).GetInterface("IBirthable");
		
        var properties = identifiableInterface.GetProperties();
		
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
		
        properties = birthableInterface.GetProperties();
		
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
		
		// Code for the problem
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var id = Console.ReadLine();
        var birthdate = Console.ReadLine();
		
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);
    }
}
