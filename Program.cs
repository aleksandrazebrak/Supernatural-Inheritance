using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;
      
      //testing Pupil class
      //Pupil p = new Pupil("Mezil-kree");
      Pupil p = new Pupil("Mezil-kree", "Icecrown");


      storms[stormsIndex] = p.CastWindStorm();
      stormsIndex ++;

      //testing Mage class
      //Mage m = new Mage("Gul'dan");
      Mage m = new Mage("Gul'dan", "Draenor");


      storms[stormsIndex] = m.CastRainStorm();
      stormsIndex ++;

      //testing Archmage class
      //Archmage a = new Archmage("Nielas Aran");
      Archmage a = new Archmage("Nielas Aran", "Stormwind");

      storms[stormsIndex] = a.CastWindStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastLightningStorm();
      stormsIndex++;

      for (int i = 0; i < stormsIndex; i++)
      {
        Console.WriteLine(storms[i].Announce());
      }


    }
  }
}