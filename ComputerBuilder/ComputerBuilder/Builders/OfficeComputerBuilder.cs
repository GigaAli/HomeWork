using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerBuilder.Services;

namespace ComputerBuilder.Builders;

public class OfficeComputerBuilder : AbstractComputerBuilder
{
    public override void SetProcessor(string processor)
    {
        _computer.Processor = processor;
    }

    public override void SetMemory(int memory)
    {
        _computer.Memory = memory;
    }

    public override void SetVideoCard(string videoCard)
    {
        _computer.VideoCard = videoCard;
    }
}