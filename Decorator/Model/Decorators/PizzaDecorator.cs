using Decorator.Model.Abstract;

namespace Decorator.Model.Decorators
{
    public class PizzaDecorator : Pizza
    {
        protected readonly Pizza Pizza;

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return Pizza.Description;
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost();
        }
    }
}
