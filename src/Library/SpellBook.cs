namespace Library;

public class SpellBook
{
    public string Name {get; set;}
    public int AttackValue {get; set;}
    public SpellBook (string name)
    {
        this.Name = name;
        this.AttackValue = 70;
    }

}