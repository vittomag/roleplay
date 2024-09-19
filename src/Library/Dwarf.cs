namespace Library;
using System.Collections;
public class Dwarf
{
    public string Name{get; set;} 
    public int Health{get; set;}
    public Dwarf(string name) 
    { 
        this.Name = name;
        this.Health = 100;
    }

    public Hammer Hammer { get; set; }
    public Shield Shield { get; set; }

    public int GetAttackvalue()
    {
        if (this.Hammer != null) //Verifica si tiene el elemento Hammer 
        {
            int attack = Hammer.AttackValue;
            return attack; //Devuelve el valor de ataque
        }

        return 0; //Si no lo tiene devuelve 0
    }
    public int GetDefensevalue()
    {
        if (this.Shield != null) //Verifica si tiene el elemento Shield
        {
            int defense = Shield.DefenseValue;
            return defense; //Si lo tiene devuelve el valor de la defensa
        }

        return 0; //Si no lo tiene devuelve 0
    }
    public int AttackOther(Dwarf dwarf) //Cuando sucede la pelea el valor de la vida va a disminuir
    {
        int attackValue = this.GetAttackvalue();
        int defenseValue = dwarf.GetDefensevalue();
        if (attackValue > 0) //Si el valor de ataque es mayor a 0 se disminuye la vida del personaje
        {
            dwarf.Health -= attackValue - defenseValue; //La vida disminuye según la diferencia del ataque del atacante y la defensa del que lo recibe
        }

        return dwarf.Health; //Devuelve el valor de la vida
    }
    public int Heal()
    {
        if (this.Health < 100) //Si la vida es menor a 100 el personaje se va a poder curar
        {
            this.Health += this.Health/2; 
            if (this.Health > 100) //Si al curarse se excede a 100 que es el valor máximo
            {
                this.Health = 100; //Se pone la vida al 100 (el máximo)
            }
        }
        
        return this.Health;
    }

}