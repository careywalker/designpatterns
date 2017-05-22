using Decorator.Model.Abstract;
using Decorator.Model.Decorators;

namespace Decorator.Model.ConcreteDecorators
{
    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(Pizza pizza) : base(pizza)
        {
            Description = "Pepperoni";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.75;
        }
    }
}
