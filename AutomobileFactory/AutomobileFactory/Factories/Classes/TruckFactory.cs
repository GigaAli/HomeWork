using AutomobileFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFactory.Factories.Classes;

public class TruckFactory
{
    public T CreateAutomobile<T>() where T : IAutomobile
    {
        Console.WriteLine("This is a Truck");

        var character = Activator.CreateInstance<T>();

        return character;
    }
}
