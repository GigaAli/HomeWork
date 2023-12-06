using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerBuilder.Classes;

namespace ComputerBuilder.Services;

public interface IComputerBuilder
{
    void SetProcessor(string processor);
    void SetMemory(int memory);
    void SetVideoCard(string videoCard);
    Computer Build();
}