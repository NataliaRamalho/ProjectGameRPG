using ProjectGameRPG.src.Entities;
using static System.Console;

class Program{
    static void Main(string[] args){
        Knight arus = new Knight("Arus", 10, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
        WriteLine(arus.Attack());
        WriteLine(wizard.Attack());
        WriteLine(wizard.Attack(1));
        WriteLine(wizard.Attack(10));
    }
}