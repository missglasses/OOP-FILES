using System;

class GameCharacter
{
    // TODO: private health
    private int health;
    
    //constructor 
     public GameCharacter(int initialHealth)
    {
        health = initialHealth;
    }
    
    // TODO: TakeDamage method
     public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        Console.WriteLine($"Ouch! Took {damage} damage. Current HP: {health}");
    }
    
    // TODO: Heal method
     public void Heal(int healingAmount)
    {
        health += healingAmount;
        if (health > 100) health = 100;
        Console.WriteLine($"Healed {healingAmount}. Current HP: {health}");
    }
    

}

class Program
{
    static void Main()
    {
        GameCharacter hp = new GameCharacter(100); //init 7-
        hp.TakeDamage(30); 
        hp.Heal(20);      
        hp.TakeDamage(100); 
    }
}
