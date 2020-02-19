using System;

namespace JurassicPark
{

  public class Dinosaur
  {
    /*

    Name
    DietType - This will be carnivore or herbivore
    DateAcquired - This will be defaulted when the dinosaur is created
    Weight - In pounds, how heavy the dinosaur is
    EnclosureNumber - the Pen that the dinosaur is currently in, thing should be a number

    */

    public string Name { get; set; }

    public string DietType { get; set; }

    public DateTime DateAcquired { get; set; }

    public int Weight { get; set; }

    public int EnclosureNumber { get; set; }

    public int DinoID { get; set; }

  }
}