using ProjectGameRPG.src.Entities;
using ProjectGameRPG.src.Enums;
using static System.Console;

class Program{
    static void Main(string[] args){
        Knight knight = new Knight("Cavaleiro", 1);
        Wizard wizardFire = new Wizard("Feticeiro do fogo", 1,EnumMagicTypes.Fire);
        Wizard wizardIce = new Wizard("Feticeiro do gelo", 1,EnumMagicTypes.Ice);
        Wizard wizardHealing = new Wizard("Feticeiro de vida", 1,EnumMagicTypes.Healing);
        Ninja ninja = new Ninja("Ninja", 3 );

        WriteLine("");
        WriteLine(knight);
        WriteLine(wizardFire);
        WriteLine(wizardIce);
        WriteLine(wizardHealing);
        WriteLine(ninja);
        WriteLine("");

        WriteLine(knight.Attack(ninja));
        WriteLine(ninja);
        WriteLine(knight);

        WriteLine(wizardIce.Attack(knight));
        WriteLine(wizardIce);
        WriteLine(knight);


        WriteLine(knight.Attack(wizardIce));
        WriteLine(wizardIce);
        WriteLine(knight);

        WriteLine(ninja.Attack(knight,100));
        WriteLine(ninja);
        WriteLine(knight);

        WriteLine(wizardHealing.Attack(ninja));
        WriteLine(wizardHealing);
        WriteLine(ninja);
      
    }
}