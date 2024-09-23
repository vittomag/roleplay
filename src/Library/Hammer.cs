namespace Library;

public class Hammer : IItem
{
    public int AttackValue { get; }
    
    public int DefenseValue { get; }
    
    public string Name { get; set; }


    public Hammer(string name)
    {
        this.Name = name;
        this.DefenseValue = 0;
        this.AttackValue = 30;
    }



}


