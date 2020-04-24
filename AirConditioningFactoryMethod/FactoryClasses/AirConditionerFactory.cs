
using AirConditioningFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioningFactoryMethod.FactoryClasses
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
