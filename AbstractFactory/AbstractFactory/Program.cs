
using AbstractFactory.Entities.Interfaces;
using AbstractFactory.Factories.Classes;
using AbstractFactory.Factories.Interfaces;



IAbstractFactory carFactory = new CarFactory();


IVehicle car = carFactory.CreateVehicle();

car.Drive();

IAbstractFactory motorcycleFactory = new MotorcycleFactory();

IVehicle motorcycle = motorcycleFactory.CreateVehicle();


motorcycle.Drive();

IAbstractFactory airplaneFactory = new AirplaneFactory();


IVehicle airplane = airplaneFactory.CreateVehicle();


airplane.Drive();


IAbstractFactory shipFactory = new ShipFactory();


IVehicle ship = shipFactory.CreateVehicle();


ship.Drive();
