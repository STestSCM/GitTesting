using System;

public class Citizen : IPerson, IIdentifiable, IBirthable
{
    private string id;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public int Age { get; private set; }

    public string Name { get; private set; }

    public string Id
    {
        get
        {
            return Id;
        }
        private set
        {
            id = value;
        }
    }

    public string Birthdate { get; private set; }
}
