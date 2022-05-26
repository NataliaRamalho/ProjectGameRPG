using ProjectGameRPG.src.entities;
using static System.Console;

class Program{
    static void Main(string[] args){
        Hero hero = new Hero("Arus", 10, "Knight");
        WriteLine(hero);
    }
}