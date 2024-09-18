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
        if (this.Bow != null)
        {
            int attack = Bow.AttackValue;
            return attack;
        }

        return 0;
    }
    public int GetDefensevalue()
    {
        
        int defense = Ring.DefenseValue;
        return defense;
    }
    public int AttackOther(Elf elf)
    {
        int attackValue = this.GetAttackvalue();
        int defenseValue = elf.GetDefensevalue();
        elf.Health -= attackValue - defenseValue;
        return elf.Health;
    }
    public int Heal()
    {
        if (Health < 100)
        {
            this.Health += Health/2;
        }
        return Health;
    }

}