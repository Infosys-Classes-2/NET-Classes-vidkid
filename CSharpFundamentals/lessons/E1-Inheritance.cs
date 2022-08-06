// using System;
// public class LivingThings
// {
//     public string food;
//     public string scientificName;

//     public void eat()
//     {
//         Console.WriteLine($"I am eating {food}");

//     }
// }
// public class Plant : LivingThings
// {
//     public bool flowering;
//     public int leafCount;

//     public void PrintFlowerDetail()
// {
//     var x = flowering ? "flowering" : "non-flowering";
//     Console.WriteLine($"I am {x} plant.");

// }
// }
// public class Animal: LivingThings
// {
//     public byte noOfLegs;

//     public AnimalType type;

//     public void PrintAnimalDetail()
//     {
//         var x = type ==AnimalType.Vertibrates ? "bones" : " no bones";
//         Console.WriteLine($"I Have {x}");
//     }
// }
// public class Human : Animal
// {

// }
// public class Yarshagumba : Plant, IAnimal
// {
//    public void PrintAnimalDetail()
//    {

//    }
// }
// public interface IAnimal
// {
//     public void PrintAnimalDetail();
// }
// public enum AnimalType
// {
//     Vertibrates,
//     Invertibrates
// }
