class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method

    // Constructor to initialize with a default value for Strength, Intelligence, Dexterity, and Health
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    // Constructor to assign custom values to all fields
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    // Attack method
    public int Attack(Human target)
    {
        int damage = Strength * 3;
        target.Health -= damage;
        return target.Health;
    }

    
}
