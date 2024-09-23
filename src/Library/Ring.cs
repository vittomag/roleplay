namespace Library;


public class Ring : IItem
{
    public string Name {get; set;}


    public int AttackValue { get; set; }
    public int DefenseValue { get; set;}
    public Ring (string name)
    {
        this.Name = name;
        this.AttackValue = 0;
        this.DefenseValue = 5;


    }




}