namespace Library;

public class Hammer
{
    public int AttackValue { get; set; }
    
    public int DefenseValue { get; set; }
    
    public string Name { get; set; }


    public Hammer(string name)
    {
        this.Name = name;
        this.DefenseValue = 0;
        this.AttackValue = 30;
    }



}


