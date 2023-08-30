using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy.Models;

internal abstract class Duck
{

    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;
    public void Quack() {
        Console.WriteLine("Quack");
    }
    public void Swim() {
        Console.WriteLine("Swim");
    }
    public void Display() {
        Console.WriteLine("Pato");
    }

    public void PerfomrQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void DefineFlyComportament(IFlyBehavior fly)
    {
        FlyBehavior = fly;  
    }

    public void DefineQuackComportament(IQuackBehavior quack)
    {
        QuackBehavior = quack;
    }

}
