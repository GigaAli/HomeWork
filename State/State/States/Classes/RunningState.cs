using State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States.Classes;

public class RunningState : IState
{
    public void Move()
    {
        Console.WriteLine("The character moves at a speed of 10 steps per second.");
    }
}