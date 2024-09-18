class Program
{
    public static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */
        List<Pet> petList = new List<Pet>
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        };
        foreach (Pet pet in petList)
        {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }

    }
}