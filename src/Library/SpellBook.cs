namespace Library;

public class SpellBook : IItem
{
    public string Name {get; set;}
    public int AttackValue {get; set;}
    public SpellBook (string name)
    {
        this.Name = name;
        this.AttackValue = 70;
    }

}