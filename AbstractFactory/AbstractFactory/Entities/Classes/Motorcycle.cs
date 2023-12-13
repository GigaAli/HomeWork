using AbstractFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities.Clases;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Motocycle Rides");
    }
}