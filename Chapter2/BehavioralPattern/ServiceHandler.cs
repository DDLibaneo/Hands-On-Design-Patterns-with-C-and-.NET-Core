using System;

namespace BehavioralPattern
{
    internal abstract class ServiceHandler
    {
        protected ServiceHandler _nextServiceHandler;
        protected ServiceRequirements _servicesProvided;

        public ServiceHandler(ServiceRequirements servicesProvided)
        {
            _servicesProvided = servicesProvided;
        }

        public void Service(Car car)
        {
            if (_servicesProvided == (car.Requirements & _servicesProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._servicesProvided} services.");
                car.Requirements &= ~_servicesProvided;
            }

            if (car.IsServiceComplete || _nextServiceHandler == null)
                return;
            else
                _nextServiceHandler.Service(car);
        }

        public void SetNextServiceHandler(ServiceHandler handler)
        {
            _nextServiceHandler = handler;
        }
    }
}
