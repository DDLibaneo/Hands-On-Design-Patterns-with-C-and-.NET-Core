namespace LiskovPrinciple
{
    class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof";
        }
    }
}
