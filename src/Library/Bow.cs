namespace Library;

public class Bow
{
    public int AttackValue { get; set; }
    
    public int DefenseValue { get; set; }
    
    public string Name { get; set; }


    public Bow(string name)
    {
        this.Name = name;
        this.AttackValue = 60;
        this.DefenseValue = 0;
    }
}