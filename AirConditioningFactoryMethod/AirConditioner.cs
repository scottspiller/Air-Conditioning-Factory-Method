
using AirConditioningFactoryMethod.Enums;
using AirConditioningFactoryMethod.FactoryClasses;
using AirConditioningFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;


namespace AirConditioningFactoryMethod
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        public AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>();

            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                // don’t have to manually add action and factory creator for each action when using refection.
                var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("AirConditioningFactoryMethod.FactoryClasses." + Enum.GetName(typeof(Actions), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public static AirConditioner IntitalizeFactories() => new AirConditioner();

        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
    }
}
