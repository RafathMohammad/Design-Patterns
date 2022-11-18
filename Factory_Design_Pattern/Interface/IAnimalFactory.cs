namespace Factory_Design_Pattern
{
    interface IFactory
    {
        IAnimal CreateAnimal(string animalType);
    }
}
