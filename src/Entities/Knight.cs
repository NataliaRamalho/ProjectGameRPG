using ProjectGameRPG.src.entities;

namespace ProjectGameRPG.src.Entities
{
    public class Knight : Hero
    {
        private int ShieldPoints;
        public Knight(string Name, int Level) : base(Name, Level)
        {   
            this.ShieldPoints = CalculateShieldPoint();
        }

        private int CalculateShieldPoint()
        {
            return this.Level * 20;
        }
        public override string ReceiveAttack(int AttackPoints){
            int maxHealthPoints = this.HealthPoints + this.ShieldPoints;
            if((maxHealthPoints + AttackPoints) > 0){
                if((this.HealthPoints + AttackPoints) < 0){
                    int rest = this.HealthPoints + AttackPoints;
                    this.ShieldPoints = this.ShieldPoints - rest;
                }
                this.HealthPoints = this.HealthPoints + AttackPoints;
                return this.Name + " recebeu um ataque de "+ AttackPoints;
            }
            else{
                this.HealthPoints = 0;
                this.ShieldPoints = 0;
                return this.Name + " recebeu um ataque de "+ AttackPoints + " e morreu.";
            }
        }
        public override string ToString(){
            return "--------" + "\n" + "Nome do Heroi: " + this.Name + "\n" + "Level: " + this.Level +  "\n" +"Vida: "+ this.HealthPoints 
            + "\n" +"Pontos de experiencia: " + ExperiencePoints+ "\n"
             + "Pontos de escudo: " + this.ShieldPoints;
        }
    }
}