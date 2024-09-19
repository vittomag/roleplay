using System.Net.NetworkInformation;

namespace Library;

public class Wizard
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
        if (this.SpellBook != null) // verifica si el personaje tiene el SpellBook 
        {
            int attack = SpellBook.AttackValue; // calcula el valor de ataque
            return attack; // retorna el valor de ataque
        }
        else 
        {
            return 10; // sino devuelve un valor predeterminado
        }
    }
    
    public int GetDefenseValue()
    {
        if (this.Cloak != null) // verifica si el personaje tiene el Cloak
        {
            int defense = Cloak.DefenseValue; // calcula el valor de la defensa
            return defense; // retorna el valor de la defensa
        }
        else
        {
            return 0; // sino devuelve un valor predeterminado
        }
    }
    
    public int AttackOther(Wizard wizard) 
    {
        int attackValue = this.GetAttackValue();
        int defenseValue = wizard.GetDefenseValue();
        wizard.Health -= attackValue - defenseValue; // calcula el daño que le hace un mago a otro basandose en su ataque y defensa respectivamente
        return wizard.Health; // retorna la vida que le queda al mago que es atacado 
    }
    
    public int Heal(Wizard wizard)
    {
        if (this.Health < 100) // verifica si la vida del mago es menor a 100
        {
            this.Health += 50; // si es asi suma 50 punto a su vida
            if (this.Health > 100) // verifica si la vida despues de la curacion es mayor a 100
            {
                this.Health = 100;
            }
        }
        
        return this.Health; // devuelve la vida
    }
    
}