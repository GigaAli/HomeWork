using AutomobileFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFactory.Entities.Classes;

public class Sedan : IAutomobile
{
    public string Name { get; set; }
    public string HP { get; set; }
    public string Speed { get; set; }
    public string Seats { get; set; }
}
