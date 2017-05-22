using Decorator.Model.Abstract;
using Decorator.Model.Decorators;

namespace Decorator.Model.ConcreteDecorators
{
    public class JalapenoDecorator : PizzaDecorator
    {
        public JalapenoDecorator(Pizza pizza) : base(pizza)
        {
            Description = "Jalapeno";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 2.25;
        }

        public bool IsSpicy()
        {
            return true;
        }
    }
}
