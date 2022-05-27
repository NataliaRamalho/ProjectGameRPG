namespace ProjectGameRPG.src.entities
{
    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected int HealthPoints;
        protected int ExperiencePoints;

        public Hero(string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoints = this.CalculateLife();
            this.ExperiencePoints = 0;

        }
        public string getName(){
            return this.Name;
        }
        public int getHealthPoint(){
            return this.HealthPoints;
        }

        public virtual string Attack(Hero hero){
            if(hero.getHealthPoint() == 0 || this.HealthPoints == 0){
                string deadHero = this.HealthPoints == 0 ? this.Name : hero.getName(); 
                return "Não é possivel realizar o ataque!!. O heroi " + deadHero +" morreu.";
            }
            string message;
            this.ExperiencePoints= this.ExperiencePoints + 15;
            message = hero.ReceiveAttack(-10);
            bool levelUp = this.IsLevelUp();
            if(levelUp){
                return this.Name + " atacou " + hero.getName() + "\n" + hero.getName() + "subiu de nível!!" + "\n" + message;
            }
            return this.Name + " atacou " + hero.getName() + "\n" + message;
        }

        public bool IsLevelUp()
        {
            int maxExperiencePoints = this.Level * 100;
            if(this.ExperiencePoints >= maxExperiencePoints){
                int experiencePoints = maxExperiencePoints - this.ExperiencePoints;
                this.LevelUp(experiencePoints);
                return true;
            }
            return false;
        }

        public virtual string ReceiveAttack(int AttackPoints){
            if(this.HealthPoints > AttackPoints){
                this.HealthPoints = this.HealthPoints + AttackPoints;
                return this.Name + " recebeu um ataque de "+ AttackPoints;
            }
            else{
                this.HealthPoints = 0;
                return this.Name + " recebeu um ataque de "+ AttackPoints + " e morreu.";
            }
        }

        private int CalculateLife(){
           return this.Level * 50;
        }

        private void LevelUp(int ExperiencePoints){
            this.Level++;
            this.HealthPoints = CalculateLife();
            this.ExperiencePoints = ExperiencePoints;
        }
        public override string ToString(){
            return "--------" + "\n" + "Nome do Heroi: " + this.Name + "\n" + "Level: " + this.Level +  "\n" +"Vida: "+ this.HealthPoints 
            + "\n" +"Pontos de experiencia: " + ExperiencePoints;
        }
    }
}