using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Factory.Factories;
using Factory.Model.Abstract;

namespace Factory.Infrastructure
{
    public class PizzaFactoryResolver
    {
        private Dictionary<string, Type> _pizzaFactories;
        public PizzaFactoryResolver()
        {
            LoadTypesICanReturn();
        }

        public IPizzaFactory CreateInstance(string factoryName)
        {
            var type = GetTypeToCreate(factoryName);

            if (type == null)
            {
                return new NullPizzaFactory();
            }

            return Activator.CreateInstance(type) as IPizzaFactory;
        }

        public Dictionary<string, Type> GetPizzaFactoryTypes()
        {
            return _pizzaFactories;
        }

        private Type GetTypeToCreate(string pizzaFactoryName)
        {
            return
                (from pizza in _pizzaFactories where pizza.Key.Contains(pizzaFactoryName) select _pizzaFactories[pizza.Key]).FirstOrDefault();
        }

        private void LoadTypesICanReturn()
        {
            _pizzaFactories = new Dictionary<string, Type>();

            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.GetInterface(typeof(IPizzaFactory).ToString()) != null)
                {
                    _pizzaFactories.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
