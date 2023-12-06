using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerBuilder.Classes;

namespace ComputerBuilder.Services;

public abstract class AbstractComputerBuilder : IComputerBuilder
{
    protected readonly Computer _computer;

    public AbstractComputerBuilder()
    {
        _computer = new Computer();
    }

    public abstract void SetProcessor(string processor);
    public abstract void SetMemory(int memory);
    public abstract void SetVideoCard(string videoCard);

    public virtual Computer Build()
    {
        return _computer;
    }
}