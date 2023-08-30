using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy.Models;

public class NoFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly anymore");
    }
}
