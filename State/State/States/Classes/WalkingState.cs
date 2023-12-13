using State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States.Classes;
public class WalkingState : IState
{
    public void Move()
    {

        Console.WriteLine("The character moves at a speed of 5 steps per second.");
    }
}
