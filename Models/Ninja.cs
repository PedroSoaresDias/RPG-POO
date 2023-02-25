using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPOOCSharp.Models
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Lançou as suas Shurinkens";
        }
    }
}