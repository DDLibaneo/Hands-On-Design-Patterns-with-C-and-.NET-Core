namespace ObserverPattern
{
    internal class Subject
    {
        private int _quantity = 0;

        // "The delegate keyword defines the format or handler that will be called."
        // The delegate to be used when the quantity is updated is shown in the following code:
        public delegate void QuantityUpdated(int quantity);
        // The delegate defines QuantityUpdated to be a method that receives an integer and 
        // does not return any value.
        // Delegate representa a assinatura do método que pode ser adicionado ao evento.
        // Aparentemente não representa nada além de: o método que vc atribuir ao evento de mesmo
        // Nome precisa ter essa assinatura especificada.

        public event QuantityUpdated OnQuantityUpdated;

        public void UpdateQuantity(int value)
        {
            _quantity += value;

            // alert any observers
            OnQuantityUpdated?.Invoke(_quantity);
        }
    }
}
