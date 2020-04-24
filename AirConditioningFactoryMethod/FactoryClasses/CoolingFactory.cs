
using AirConditioningFactoryMethod.Interfaces;
using AirConditioningFactoryMethod.Managers;

namespace AirConditioningFactoryMethod.FactoryClasses
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new CoolingManager(temperature);
    }
}
