namespace Library;

public class Cloak
{
    public string Name {get; set;}
    public int DefenseValue{get; set;}
    public Cloak(string name)
    {
        this.Name = name;
        this.DefenseValue = 10;
    }

}