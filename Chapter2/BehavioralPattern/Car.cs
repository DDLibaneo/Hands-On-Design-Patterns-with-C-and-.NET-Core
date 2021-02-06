namespace BehavioralPattern
{
    internal class Car
    {
        public ServiceRequirements Requirements { get; set; }

        public bool IsServiceComplete
        {
            get
            {
                return Requirements == ServiceRequirements.None;
            }
        }
    }
}
