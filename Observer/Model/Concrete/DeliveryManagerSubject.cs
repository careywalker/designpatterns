using Observer.Model.Abstract;

namespace Observer.Model.Concrete
{
    public class DeliveryManagerSubject : Subject
    {
        private Delivery _delivery;

        public Delivery Delivery
        {
            get { return _delivery; }
            set
            {
                _delivery = value;
                Notify();
            }
        }
    }
}
