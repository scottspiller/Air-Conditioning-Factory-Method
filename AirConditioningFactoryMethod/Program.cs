using AirConditioningFactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioningFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .IntitalizeFactories()
                .ExecuteCreation(Actions.Cooling, 22.5)
                .Operate();
            Console.ReadKey();
        }
    }
}
