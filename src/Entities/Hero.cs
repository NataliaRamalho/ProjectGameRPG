namespace ProjectGameRPG.src.entities
{
    public abstract class Hero
    {
        public Hero (){
            this.Name = string.Empty;
            this.HeroType = string.Empty;
        }
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level +  " "+ this.HeroType;
        }
        public virtual string Attack(){
            return this.Name + "atacou com sua espada";
        }
    }
}