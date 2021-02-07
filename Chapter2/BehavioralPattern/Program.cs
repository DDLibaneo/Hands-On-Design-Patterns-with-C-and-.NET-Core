using System;

namespace BehavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic();
            var wheels = new WheelSpecialist();
            var qa = new QualityControl();
            var detailer = new Detailer();            

            mechanic.SetNextServiceHandler(wheels);
            wheels.SetNextServiceHandler(qa);
            qa.SetNextServiceHandler(detailer);

            Console.WriteLine("Car 1 is dirty");

            var car1 = new Car()
            {
                Requirements = ServiceRequirements.Dirty
            };

            mechanic.Service(car1);

            Console.WriteLine();

            Console.WriteLine("Car 2 requires full service");

            var car2 = new Car()
            {
                Requirements = ServiceRequirements.Dirty |
                    ServiceRequirements.EngineTune |
                    ServiceRequirements.TestDrive |
                    ServiceRequirements.WheelAlignment
            };

            mechanic.Service(car2);

            Console.Read();
        }
    }
}
