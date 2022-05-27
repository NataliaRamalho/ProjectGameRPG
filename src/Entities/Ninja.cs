using ProjectGameRPG.src.entities;

namespace ProjectGameRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level) : base(Name, Level)
        {
        }

        public string Attack(Hero hero, int bonus){
            if(hero.getHealthPoint() == 0 || this.HealthPoints == 0){
                string deadHero = this.HealthPoints == 0 ? this.Name : hero.getName(); 
                return "Não é possivel realizar o ataque!!. O heroi " + deadHero +" morreu.";
            }
            string message;
            this.ExperiencePoints=+20;
            message = hero.ReceiveAttack(-(10 + bonus));
            bool levelUp = this.IsLevelUp();
            if(levelUp){
                return this.Name + " atacou " + hero.getName() + " com bonus de ataque de: " + bonus +  "\n " + hero.getName() + "com bonus de ataque de: " + " subiu de nível!!" + "\n" + message;
            }
            return this.Name + " atacou " + hero.getName() + " com bonus de ataque de: " + bonus + "\n" + message;
        }
    }
}