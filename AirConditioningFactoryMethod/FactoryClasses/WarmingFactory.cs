

using AirConditioningFactoryMethod.Interfaces;
using AirConditioningFactoryMethod.Managers;

namespace AirConditioningFactoryMethod.FactoryClasses
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new WarmingManager(temperature);
    }
}
