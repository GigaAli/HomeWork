using AbstractFactory.Entities.Clases;
using AbstractFactory.Entities.Interfaces;
using AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Classes;

public class MotorcycleFactory : IAbstractFactory
{
    public IVehicle CreateVehicle()
    {
        return new Motorcycle();
    }

}