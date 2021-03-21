namespace LiskovPrinciple
{
    internal class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meouw";
        }
    }
}
