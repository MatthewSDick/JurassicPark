using System;
using System.Linq;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Jurasic Park Dinosaur tracker.");
      //Console.WriteLine("Here is a list of the current dinosaurs we have.");
      var tracker = new DinosaurTracker();

      var isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("(VIEW), (ADD), (REMOVE), (TRANSFER), (DIET), (HEAVIEST) or (QUIT)");
        var input = Console.ReadLine().ToLower();

        switch (input)
        {

          case "view":
            // Display the Dinosaurs

            var sortedDinosaurList = tracker.Dinosaur.OrderByDescending(Dinosaur => Dinosaur.DateAcquired).ToList();


            foreach (var s in sortedDinosaurList)
            {
              Console.WriteLine($"Dinosaur {s.Name} that arrived on {s.DateAcquired} lives in enclosure {s.EnclosureNumber} and weighs {s.Weight} pounds and is a {s.DietType}.");
            }
            break;

          case "add":
            Console.WriteLine("What is the name of your dinosaur?");
            var dinoName = Console.ReadLine();
            Console.WriteLine($"Is {dinoName} a (CARNIVORE) or (HERBIVORE)?");
            var diet = Console.ReadLine();
            Console.WriteLine($"What is {dinoName} weight?");
            var weight = int.Parse(Console.ReadLine());
            Console.WriteLine($"What enclosure is {dinoName} located?");
            var enclosure = int.Parse(Console.ReadLine());

            tracker.AddNewDinosaur(dinoName, diet, weight, enclosure);
            Console.Clear();
            break;

          case "remove":
            Console.WriteLine("Which dinosaur do you want to remove?");
            var dinoToRemove = Console.ReadLine();
            tracker.RemoveDinosaur(dinoToRemove);
            break;

          case "transfer":
            Console.WriteLine("Which dinosaur do you want to move?");
            var dinoToMove = Console.ReadLine();
            Console.WriteLine("What enclosure do you want to move the dinosaur to?");
            var newEnclosure = int.Parse(Console.ReadLine());

            tracker.MoveDinosaur(dinoToMove, newEnclosure);

            break;

          case "diet":
            // Ask for diet type
            // This will the total number of each type of diet

            tracker.DietCount(out int carnivore, out int herbivore);
            Console.Write($"There are currently {carnivore} carnivores and {herbivore} herbivores.");

            break;

          case "heaviest":
            tracker.ThreeHeavies();
            break;

          case "quit":
            // quit program
            isRunning = false;

            break;
        }


      }
      Console.WriteLine("Another asteroid killed all the dinosaurs again..... goodbye.");








    }
  }
}

