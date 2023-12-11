using AutomobileFactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileFactory.Factories.Interfaces;

public interface IAutomobileFactory
{
    public T CreateAutomobile<T>() where T : IAutomobile;
}
