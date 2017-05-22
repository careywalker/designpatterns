using Decorator.Model.Abstract;
using Decorator.Model.Decorators;

namespace Decorator.Model.ConcreteDecorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.25;
        }
    }
}
