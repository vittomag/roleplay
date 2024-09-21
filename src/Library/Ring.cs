namespace Library;

public class Ring : IItem
{
    public string Name {get; set;}
    public int AttackValue { get; }
    public int DefenseValue{ get; }
    public Ring(string name)
    {
        this.Name = name;
        this.AttackValue = 0;
        this.DefenseValue = 5;
    }

}