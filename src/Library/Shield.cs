namespace Library;

public class Shield
{
    public int AttackValue { get; set; }
    
    public int DefenseValue { get; set; }
    
    public string Name { get; set; }


    public Shield(string name)
    {
        this.Name = name;
        this.AttackValue = 0;
        this.DefenseValue = 20;
    }
}

