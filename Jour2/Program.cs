using System;

public class Animal
{
    public string Name;
    
    public void Move()
    {
        Console.WriteLine("Move");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleep");
    }

    public Animal()
    {
        this.Name = "";
    }
    public Animal(String Name)
    {
        this.Name = Name;
        this.Move();
        this.Sleep();
    }


}

class Program
{
    static void Main(string[] args)
    {
        Animal sandwich = new Animal("Chat");
    }
}