using Library;

namespace LibraryTests;

public class TestDwarf
{

    [Test]
    public void TestAttackValue()
    {
        const string name = "Enano";
        Dwarf enano = new Dwarf(name);
        Hammer hammer = new Hammer("Hammer");
        Shield shield = new Shield("Shield");
        enano.Hammer = hammer;
        enano.Shield = shield;
      
        int attack = hammer.AttackValue + shield.AttackValue;
        Assert.AreEqual(attack, enano.AttackValue);
      
    }


    [Test]
    public void TestDeffenseValue()
    {
        const string name = "Enano";
        Dwarf enano = new Dwarf(name);
        Hammer hammer = new Hammer("Hammer");
        Shield shield = new Shield("Shield");
        enano.Hammer = hammer;
        enano.Shield = shield;
      
        int defense = hammer.DefenseValue + shield.DefenseValue;
        Assert.AreEqual(defense, enano.DefenseValue);  
    }


}