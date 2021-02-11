namespace ObserverPattern
{
    internal class Subject
    {
        private int _quantity = 0;

        // "The delegate keyword defines the format or handler that will be called."
        // The delegate to be used when the quantity is updated is shown in the following code:
        public delegate void QuantityUpdatedEventHandler(int quantity);
        // This delegate defines QuantityUpdated to be a method that receives an integer and 
        // does not return any value.        
        // "The delegate defines the signature for the event handler method of the subscriber class."

        public event QuantityUpdatedEventHandler QuantityUpdated;

        public void AddToQuantity(int value)
        {
            _quantity += value;

            OnUpdateQuantity();
        }

        public void OnUpdateQuantity()
        {
            // alert any observers
            QuantityUpdated?.Invoke(_quantity);
        }
    }
}
