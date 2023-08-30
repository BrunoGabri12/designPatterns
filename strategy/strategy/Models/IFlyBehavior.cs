//Desacoplamento dos comportamentos que estão variando. 

namespace strategy.Models;

internal interface IFlyBehavior
{
    public void Fly();
}
