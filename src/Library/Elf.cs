namespace Library;
using System.Collections;
public class Elf : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Elf(string name)
    {
        this.Name = name;
        this.Health = 100;
    }
    public Bow Bow { get; set; }
    public Ring Ring { get; set; }
    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }
    public int DefenseValue
    {
        get
        {
            return Ring.DefenseValue;
        }
    }
    public void AttackOther(ICharacter character) //Cuando sucede la pelea el valor de la vida va a disminuir
    {
        int attackValue = this.AttackValue;
        int defenseValue = character.DefenseValue;
        
        if (attackValue > 0) //Si el valor de ataque es mayor a 0 se disminuye la vida del personaje
        {
            this.Health -= attackValue - defenseValue; //La vida disminuye según la diferencia del ataque del atacante y la defensa del que lo recibe
        }
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