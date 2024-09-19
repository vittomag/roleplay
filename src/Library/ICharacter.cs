namespace Library;

public interface ICharacter
{ 
    int Health { get; set; }
    void AttackOther(ICharacter attacked);
    void Heal(ICharacter cured);
}