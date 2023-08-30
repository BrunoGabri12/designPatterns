using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy.Models;

internal class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Fly With Wings !!");
    }
}
