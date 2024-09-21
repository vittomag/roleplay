namespace Library;

public interface ICharacter
{
    string Name { get; set; }
    int Health { get; set; }
    int AttackValue { get;}
    int DefenseValue { get; }
    void AttackOther(ICharacter attacked);
    void Heal();
}