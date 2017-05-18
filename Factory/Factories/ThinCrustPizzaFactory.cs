using Factory.Model.Abstract;
using Factory.Model.Concrete.Pizza;

namespace Factory.Factories
{
    public class ThinCrustPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new ThinCrustPizza();
        }
    }
}
