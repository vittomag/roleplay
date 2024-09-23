namespace Library;

public class Shield : IItem
{
    public int AttackValue { get; }
    
    public int DefenseValue { get; }
    
    public string Name { get; set; }


    public Shield(string name)
    {
        this.Name = name;
        this.AttackValue = 0;
        this.DefenseValue = 20;
    }
}

