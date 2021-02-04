namespace LiskovPrinciple
{
    internal class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof";
        }
    }
}
