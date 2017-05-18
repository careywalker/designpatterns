using Factory.Model.Abstract;
using Factory.Model.Concrete.Pizza;

namespace Factory.Factories
{
    public class PieCrustPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new PieCrustPizza();
        }
    }
}
