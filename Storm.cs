// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
    // type of storm - wind or rain
    //public string Essence
    //{ get; private set; }
    
    // true if storm is strong
    //public bool IsStrong
    //{ get; private set; }
    
    // title of the magician
    //public string Caster
    //{ get; private set; }

    public Storm (string essence, bool isStrong, string caster)
    {
      this.Essence = essence;
      this.IsStrong = isStrong;
      this.Caster = caster;    
    }

    public override string Announce()
    {      
      if(IsStrong)
      {
        return $"{Caster} cast a strong {Essence} storm!";
      }
      else
      {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }
    
  }
}
