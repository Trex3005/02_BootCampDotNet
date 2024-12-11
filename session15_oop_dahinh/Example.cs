using System.Drawing;

abstract class Animal
{
    private string name;
    public string Name
    {
        get{return name;}
        set{name = value;}
    }
    public Animal(string name)
    {
        this.name = name;
    }
    public abstract void Speak();

    public abstract void displayInfo();
}

class Dog: Animal
{
    private string breed; //giống cún
    public string Breed
    {
        get{return breed;}
        set{breed = value;}
    }
    public Dog(string name, string breed): base(name)
    {
        this.breed = breed;
    }
    public override void Speak()
    {
        System.Console.WriteLine("Gâu Gâu");
    }

    public override void displayInfo()
    {
        System.Console.WriteLine($"Name: {Name}, Breed: {Breed}");
    }
}

class Cat: Animal
{
    private string color {get;set;}

    public Cat(string name, string color): base(name)
    {
        this.color = color;
    }

    public override void Speak()
    {
        System.Console.WriteLine("Meo meo");
    }
    public override void displayInfo()
    {
        System.Console.WriteLine($"Name: {Name}, Color: {color}");
    }
}

