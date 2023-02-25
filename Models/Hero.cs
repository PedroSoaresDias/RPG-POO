using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPOOCSharp.Models
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.HeroType}";
        }

        public virtual string Attack(){
            return $"{this.Name} Fez o ataque";
        }

        public virtual string Attack(int Bonus){
            if(Bonus > 6){
                return $"{this.Name} Fez o ataque super efetiva com bonûs de: {Bonus}";
            }
            else{
                return $"{this.Name} Seu ataque está fraco e não foi efetivo com bonûs de: {Bonus}";
            }
        }
    }
}