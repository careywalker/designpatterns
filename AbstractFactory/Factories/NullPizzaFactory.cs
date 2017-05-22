using Factory.Model.Abstract;
using Factory.Model.Concrete.Pizza;

namespace Factory.Factories
{
    public class NullPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new NullPizza();
        }
    }
}
