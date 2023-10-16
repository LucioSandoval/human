
class Program
{
    static void Main()
    {
        // Crear instancias de la clase Human
        Human human1 = new Human("Player 1");
        Human human2 = new Human("Player 2", 5, 4, 6, 120);

        // Realizar un ataque
        int remainingHealth = human1.Attack(human2);
        Console.WriteLine($"{human1.Name} attacked {human2.Name}!");
        Console.WriteLine($"{human2.Name}'s health is now {remainingHealth}");
    }
}





