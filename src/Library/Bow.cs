namespace Library;


public class Bow : IItem
{
    public string Name {get; set;}


    public int AttackValue { get; set; }
    public int DefenseValue { get; set;}
    public Bow (string name)
    {
        this.Name = name;
        this.AttackValue = 60;
        this.DefenseValue = 0;


    }


}