using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFactory.Entities.Interfaces;

public interface IAutomobile
{
    string Name { get; set; }
    string HP { get; set; }
    string Speed { get; set; }
    string Seats { get; set; }
}
