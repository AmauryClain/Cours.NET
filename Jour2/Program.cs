using System;

public abstract class Animal
{
    private string _name;
    public string Name { get { return _name; } protected set { _name = value; } }

    public virtual void Move()
    {
        Console.WriteLine("Move");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("Sleep");
    }

}

public class Dog
{
    public string DogName { get; set; }
    public string Rarity { get; set; }
    public int DogId { get; set; }
}

public class Griffin : Animal
{
    public override void Move()
    {
        Console.WriteLine(Name + " Move");
    }
    public new void Sleep()
    {
        Console.WriteLine(Name + " sleep");
    }
    public Griffin()
    {

    }

    public Griffin(string Name)
    {
        this.Name = Name;
        this.Move();
        this.Sleep();
    }
}

public class Dragon : Animal, Pilotable
{
    public override void Move()
    {
        Console.WriteLine(Name + " Move");
    }
    public new void Sleep()
    {
        Console.WriteLine(Name + " sleep");
    }

    public void Move2()
    {
        Console.WriteLine(Name + " Moove from Pilotable");
    }
    public Dragon()
    {
        Name = "Nom par défaut";
    }
    public Dragon(String name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dragon dragon = new Dragon("GOGOLE");
        Griffin griffin = new Griffin("GROS GOGOLE");
        dragon.Move2();
        dragon.Move();
        dragon.Sleep();

        IList<Dog> dogsList = new List<Dog>()
        {
            new Dog() {DogId = 1, DogName = "Wolf", Rarity = "Rare"},
            new Dog() {DogId = 2, DogName = "Snow", Rarity = "Common" },
            new Dog() {DogId = 3, DogName = "Alexandre", Rarity = "Common"},
            new Dog() {DogId = 4, DogName = "Timéo", Rarity = "Mythique"},
            new Dog() {DogId = 5, DogName = "Amaury", Rarity = "Master"}
        };

        var testDogs = from dog in dogsList where dog.Rarity == "Common" orderby dog.DogName descending select dog;
        var testDogs2 = dogsList.Where(dog => dog.Rarity == "Rare");
        Console.WriteLine("Query Expression:");
        foreach (Dog testDog in testDogs)
        {
            Console.WriteLine(testDog.DogName + " "+ testDog.DogId);
        }
        Console.WriteLine("Method Expression:");
        foreach (Dog testDog2 in testDogs2)
        {
            Console.WriteLine(testDog2.DogName + " " + testDog2.DogId);
        }
    }
}