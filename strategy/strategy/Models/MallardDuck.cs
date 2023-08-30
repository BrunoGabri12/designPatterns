using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy.Models;

internal class MallardDuck: Duck
{
   
    public MallardDuck() {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Quack(); 
    }

 
}
