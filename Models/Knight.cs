using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPOOCSharp.Models
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou com a sua espada";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return $"{this.Name} Atacou com sua espada de forma efetiva com bonûs de {Bonus}";
            }
            else{
                return $"{this.Name} Atacou com sua espada da forma errada com bonûs de {Bonus}";
            }
        }
    }
}