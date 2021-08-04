using System;

namespace Human
{
    public class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    public int Health {get; set;}
     
    // add a public "getter" property to access health
    //  public Human() 
    // {
    //     Health = 300;
    // }
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
       public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 300;

    }
    // Add a constructor to assign custom values to all fields
     public Human(string name, int strength, int intelligence, int dexterity)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
    }
    // Build Attack method
    public int Attack(Human target)
    {
        //You dont need to use this but it helps
        target.Health -= 5 * this.Strength;
        return target.Health;
    }
}


}