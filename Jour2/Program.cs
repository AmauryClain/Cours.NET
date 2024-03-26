﻿using System;

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
    }
}