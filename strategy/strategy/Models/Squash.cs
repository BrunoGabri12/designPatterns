using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy.Models;

internal class Squash : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squash Squash Squash");
    }
}
