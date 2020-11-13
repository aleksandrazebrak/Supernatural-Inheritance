// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage
  {
    public Archmage(string title) : base (title)
    {}

    public Archmage(string title, string origin) : base (title,  origin)
    {}

    public override Storm CastRainStorm()
    {
      Storm s = new Storm ("rain", true, Title);
      return s;
    }

    public Storm CastLightningStorm()
    {
      Storm s = new Storm("lightning", true, Title);
      return s;
    }

    
  }
}
