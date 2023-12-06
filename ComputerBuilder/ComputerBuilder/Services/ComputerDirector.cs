using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerBuilder.Classes;

namespace ComputerBuilder.Services;

public class ComputerDirector
{
    private readonly IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public Computer ConstructComputer()
    {
        _builder.SetProcessor("Intel Core i5-12600K");
        _builder.SetMemory(16);
        _builder.SetVideoCard("NVIDIA GeForce RTX 3060");

        return _builder.Build();
    }
}