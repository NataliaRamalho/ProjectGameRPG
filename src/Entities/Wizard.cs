
using ProjectGameRPG.src.entities;

namespace ProjectGameRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Lançou magia";
        }
        public string Attack(int Bonus){
            return this.Name + "Lançou magia com bonus de ataque de " + Bonus;
        }
    }
}