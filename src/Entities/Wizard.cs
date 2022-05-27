
using ProjectGameRPG.src.entities;
using ProjectGameRPG.src.Enums;

namespace ProjectGameRPG.src.Entities
{
    public class Wizard : Hero
    {
        private EnumMagicTypes MagicType;
        public Wizard(string Name, int Level, EnumMagicTypes MagicType) : base(Name, Level)
        {
            this.MagicType = MagicType;
        }

        public override string Attack(Hero hero){
            string message;
            this.ExperiencePoints= + 30;
            int pointsAttack = this.CalculatePointsAttack();
            message = hero.ReceiveAttack(pointsAttack);
            bool levelUp = this.IsLevelUp();
            if(levelUp){
                return this.Name + " atacou com sua magia de  " + this.MagicType + " o heroi " + hero.getName()
                 + "\n " + hero.getName() + " subiu de nível!" + "\n" + message;
            }
            return this.Name + " atacou com sua magia de  " + this.MagicType + " o heroi " + hero.getName() + "\n" + message;
        }

        private int CalculatePointsAttack()
        {
            int pointsAttack;
            switch(this.MagicType){
                case EnumMagicTypes.Fire:
                    pointsAttack = -20;
                    break;
                case EnumMagicTypes.Ice:
                    pointsAttack = -30;
                    break;
                case EnumMagicTypes.Healing:
                    pointsAttack = 5;
                    break;
                default:
                    pointsAttack = -10;
                    break;
            }
            return pointsAttack;
        }
        
        public override string ToString(){
            return "--------" + "\n" + "Nome do Heroi: " + this.Name + "\n" + "Level: " + this.Level +  "\n" +"Vida: "+ this.HealthPoints 
            + "\n" +"Pontos de experiencia: " + ExperiencePoints+ "\n" + "Tipo de magia: " +  this.MagicType + "\n"+ "--------" ;
        }
    }
}