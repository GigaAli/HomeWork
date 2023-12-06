using ComputerBuilder.Builders;
using ComputerBuilder.Classes;
using ComputerBuilder.Services;

GamingComputerBuilder gamingBuilder = new GamingComputerBuilder();

Computer gamingComputer = new ComputerDirector(gamingBuilder).ConstructComputer();

Console.WriteLine("Gaming Computer:");
Console.WriteLine("CPU: {0}", gamingComputer.Processor);
Console.WriteLine("RAM: {0}", gamingComputer.Memory);
Console.WriteLine("VideCard: {0}", gamingComputer.VideoCard);

