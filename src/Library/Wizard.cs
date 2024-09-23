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
    
    public int AttackValue
    {
        get
        {
            return SpellBook.AttackValue + Cloak.AttackValue;
        }
    }
    
    public int DefenseValue
    {
        get
        {
            return Cloak.DefenseValue + SpellBook.DefenseValue;
        }
    }
    
    public void AttackOther(ICharacter character) 
    {
        int attackValue =  character.AttackValue;
        int defenseValue = this.DefenseValue;
        this.Health -= attackValue - defenseValue; // calcula el daño que le hace un mago a otro basandose en su ataque y defensa respectivamente
 
    }
    
    public void Heal()
    {
        if (this.Health < 100) //Si la vida es menor a 100 el personaje se va a poder curar
        {
            this.Health += this.Health/2;
            if (this.Health > 100) //Si al curarse se excede a 100 que es el valor máximo
            {
                this.Health = 100; //Queda al máximo de la vida
            }
        }
    }
    
}