namespace Library;

public class Cloak : IItem
{
    public string Name {get; set;}
    public int AttackValue { get; }
    public int DefenseValue{get;}
    public Cloak(string name)
    {
        this.Name = name;
        this.DefenseValue = 10;
        this.AttackValue = 0;
    }

}