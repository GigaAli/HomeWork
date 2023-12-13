using State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States.Classes;
public class RestingState : IState
{
    public void Move()
    {

        Console.WriteLine("Character Resting");
    }
}
