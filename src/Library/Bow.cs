namespace Library;

public class Bow : IItem
{
    public string Name {get; set;}
    public int AttackValue {get; }
    public int DefenseValue { get; }
    public Bow (string name)
    {
        this.Name = name;
        this.AttackValue = 60;
        this.DefenseValue = 0;
    }

}