using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{

  public class DinosaurTracker
  {

    public List<Dinosaur> Dinosaur { get; set; } = new List<Dinosaur>();

    public void AddNewDinosaur(string name, string diet, int weight, int enclosure)
    {
      var dinosaur = new Dinosaur
      {
        Name = name,
        DietType = diet,
        Weight = weight,
        EnclosureNumber = enclosure,
        DateAcquired = DateTime.Now
      };

      Dinosaur.Add(dinosaur);

    }


    public void RemoveDinosaur(string dinoName)
    {

      var dinosaurToRemmove = Dinosaur.First(dinosaur => dinosaur.Name == dinoName);
      Dinosaur.Remove(dinosaurToRemmove);

    }

    public void MoveDinosaur(string name, int enclosure)
    {

      Dinosaur.Find(dinosaur => dinosaur.Name == name).EnclosureNumber = enclosure;
      //Dinosaur.

    }

    public void DietCount(out int carnivoreOut, out int herbivoreOut)
    {

      var carnivore = Dinosaur.Count(Dinosaur => Dinosaur.DietType == "carnivore");
      var herbivore = Dinosaur.Count(Dinosaur => Dinosaur.DietType == "herbivore");

      carnivoreOut = carnivore;
      herbivoreOut = herbivore;

      /*
      Another option is to put the Console.Writeline here vs passing back
      */

    }

    public void ThreeHeavies()
    {
      var sorted = Dinosaur.OrderByDescending(Dinosaur => Dinosaur.Weight).ToList();

      Console.WriteLine("The three heaviest dinosaurs are...");
      for (int i = 0; i <= 2; i++)
      {
        Console.WriteLine($"{sorted[i].Name} weighs {sorted[i].Weight}");
      }

    }





  }
}