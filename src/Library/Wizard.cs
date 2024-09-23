using System.Net.NetworkInformation;

namespace Library;

public class Wizard : ICharacter
{ 
    public string Name{get; set;} 
    
    public int Health{get; set;}
    
    public Wizard(string name) 
    { 
        this.Name = name;
        this.Health = 100;
    }

    public SpellBook SpellBook { get; set; }
    public Cloak Cloak { get; set; }
    
    public int GetAttackValue()
    {
        if (this.SpellBook != null)
        {
            int attack = SpellBook.AttackValue;
            return attack;
        }
        else
        {
            return 10;
        }
    }
    
    public int GetDefenseValue()
    {
        if (this.Cloak != null)
        {
            int defense = Cloak.DefenseValue;
            return defense;
        }
        else
        {
            return 0;
        }
    }
    
    public int AttackOther(Wizard wizard) 
    {
        int attackValue = this.GetAttackValue();
        int defenseValue = wizard.GetDefenseValue();
        wizard.Health -= attackValue - defenseValue;
        return wizard.Health;
    }
    
    public int Heal(Wizard wizard)
    {
        if (this.Health < 100)
        {
            this.Health += 50; 
            if (this.Health > 100)
            {
                int resta = this.Health - 100;
                this.Health -= resta;
            }
        }
        
        return this.Health;
    }
    
}