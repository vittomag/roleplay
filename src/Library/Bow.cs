namespace Library;

public class Bow
{
    public string Name {get; set;}
    public int AttackValue {get; set;}
    public Bow (string name)
    {
        this.Name = name;
        this.AttackValue = 60;
    }

}