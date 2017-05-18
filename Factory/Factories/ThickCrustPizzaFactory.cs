using Factory.Model.Abstract;
using Factory.Model.Concrete.Pizza;

namespace Factory.Factories
{
    public class ThickCrustPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza()
        {
            return new ThickCrustPizza();
        }
    }
}
