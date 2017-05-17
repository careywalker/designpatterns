using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Factory.Model.Abstract;
using Factory.Model.Concrete.Pizza;

namespace Factory.Model.Concrete
{
    public class PizzaFactory
    {
        private Dictionary<string, Type> _pizzas;
        public PizzaFactory()
        {
            LoadTypesICanReturn();
        }

        public IPizza CreateInstance(string pizzaName)
        {
            var type = GetTypeToCreate(pizzaName);

            if (type == null)
            {
                return new NullPizza();
            }

            return Activator.CreateInstance(type) as IPizza;
        }

        public Dictionary<string, Type> GetPizzaTypes()
        {
            return _pizzas;
        }

        private Type GetTypeToCreate(string pizzaName)
        {
            return
                (from pizza in _pizzas where pizza.Key.Contains(pizzaName) select _pizzas[pizza.Key]).FirstOrDefault();
        }

        private void LoadTypesICanReturn()
        {
            _pizzas = new Dictionary<string, Type>();

            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.GetInterface(typeof(IPizza).ToString()) != null)
                {
                    _pizzas.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
