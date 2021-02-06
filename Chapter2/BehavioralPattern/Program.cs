using System;

namespace BehavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic();
            var detailer = new Detailer();
            var wheels = new WheelSpecialist();
            var qa = new QualityControl();

            qa.SetNextServiceHandler(detailer);
            wheels.SetNextServiceHandler(qa);
            mechanic.SetNextServiceHandler(wheels);

            Console.WriteLine("Car 1 is dirty");
            mechanic.Service(new Car { Requirements = ServiceRequirements.Dirty });

            Console.WriteLine();

            Console.WriteLine("Car 2 requires full service");

            var car = new Car()
            {
                Requirements = ServiceRequirements.Dirty |
                    ServiceRequirements.EngineTune |
                    ServiceRequirements.TestDrive |
                    ServiceRequirements.WheelAlignment
            };

            mechanic.Service(car);

            Console.Read();
        }
    }
}
