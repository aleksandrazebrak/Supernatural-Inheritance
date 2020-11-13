// Spell.cs
using System;

namespace MagicalInheritance
{
  abstract class Spell
  {
    // type of storm - wind or rain
    public string Essence
    { get; protected set; }
    
    // true if storm is strong
    public bool IsStrong
    { get; protected set; }
    
    // title of the magician
    public string Caster
    { get; protected set; }

    public abstract string Announce();
  }
}
