namespace ObserverPattern
{
    internal class Subject
    {
        private int _quantity = 0;
        
        public event QuantityUpdated OnQuantityUpdated;

        public void UpdateQuantity(int value)
        {
            _quantity += value;

            // alert any observers
            OnQuantityUpdated?.Invoke(_quantity);
        }
    }
}
