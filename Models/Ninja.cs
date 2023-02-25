namespace RPGPOOCSharp.Models
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Lançou as suas Shurikens";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6){
                return $"{this.Name} Arremessou suas Shurikens causou fortes danos no inimigo com bonûs de: {Bonus}";
            }
            else{
                return $"{this.Name} Arremessou suas Shurikens de forma mal executada com bonûs de: {Bonus}";
            }
        }
    }
}