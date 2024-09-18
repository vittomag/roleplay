namespace Library;

public class Ring
{
    public string Name {get; set;}
    public int DefenseValue{get; set;}
    public Ring(string name)
    {
        this.Name = name;
        this.DefenseValue = 5;
    }

}