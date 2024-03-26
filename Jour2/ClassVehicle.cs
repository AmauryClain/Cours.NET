using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle : Pilotable
{
    public void Move2()
    {
        Console.WriteLine("La voiture avance");
    }
}