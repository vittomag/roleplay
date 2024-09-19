namespace Library;
using System.Collections;
public class Elf
{
    public string Name{get; set;} 
    public int Health{get; set;}
    public Elf(string name) 
    { 
        this.Name = name;
        this.Health = 100;
    }

    public Bow Bow { get; set; }
    public Ring Ring { get; set; }

    public int GetAttackvalue()
    {
        if (this.Bow != null) //Verifica si tiene el elemento Bow 
        {
            int attack = Bow.AttackValue;
            return attack; //Devuelve el valor de ataque
        }

        return 0; //Si no lo tiene devuelve 0
    }
    public int GetDefensevalue()
    {
        if (this.Ring != null) //Verifica si tiene el elemento Ring
        {
            int defense = Ring.DefenseValue;
            return defense; //Si lo tiene devuelve el valor de la defensa
        }

        return 0; //Si no lo tiene devuelve 0
    }
    public int AttackOther(Elf elf) //Cuando sucede la pelea el valor de la vida va a disminuir
    {
        int attackValue = this.GetAttackvalue();
        int defenseValue = elf.GetDefensevalue();
        if (attackValue > 0) //Si el valor de ataque es mayor a 0 se disminuye la vida del personaje
        {
            elf.Health -= attackValue - defenseValue; //La vida disminuye según la diferencia del ataque del atacante y la defensa del que lo recibe
        }

        return elf.Health; //Devuelve el valor de la vida
    }
    public int Heal()
    {
        if (this.Health < 100) //Si la vida es menor a 100 el personaje se va a poder curar
        {
            this.Health += this.Health/2; 
            if (this.Health > 100) //Si al curarse se excede a 100 que es el valor máximo
            {
                this.Health = 100; //Pone la vida al 100
            }
        }
        
        return this.Health; //Devuelve el valor de la vida
    }

}