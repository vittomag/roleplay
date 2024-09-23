namespace Library;

public class SpellBook : IItem
{
    public string Name {get; set;}
    public int AttackValue {get; }
    public int DefenseValue { get; }
    public SpellBook (string name)
    {
        this.Name = name;
        this.AttackValue = 70;
        this.DefenseValue = 0;
    }

}