namespace LiskovPrinciple
{
    class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meouw";
        }
    }
}
