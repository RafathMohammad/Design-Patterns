namespace Factory_Design_Pattern
{
    class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Tiger":
                    return new Tiger();
                case "Dog":
                    return new Dog();
                default:
                    return null;
            }
        }
    }
}
