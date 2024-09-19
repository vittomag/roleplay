namespace Library;

public class Dwarf
{
    public string Name { get; set; }

    public int Health { get; set; }

    public Dwarf(string name)
    {
        this.Name = name;
        this.Health = 100;
    }

    public Hammer Hammer { get; set; }
    public Shield Shield { get; set; }

    public int GetAttackvalue()
    {
        if (this.Hammer != null) //Verifica si tiene el elemento Bow 
        {
            int attack = Hammer.AttackValue;
            return attack; //Devuelve el valor de ataque
        }

        return 0; //Si no lo tiene devuelve 0
    }

    public int GetDefensevalue()
    {
        int defense = Shield.DefenseValue;
        return defense;
    }

    public void AttackOther(Dwarf Dwarf)
    {
        int attackValue = GetAttackvalue();
        int defenseValue = GetDefensevalue();
        Health -= attackValue - defenseValue;
        
        // El ataque de 1 - la defensa de 2 se resta de la vida del 2
    }

    public void Heal()
    {
        if (Health < 100)
        {
            this.Health += Health / 2;
        }
    }

}
