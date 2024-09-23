namespace LibraryTests;
using Library;


public class TestElf
{


    [Test]
    public void TestAttackValue()
    {
        const string name = "Elfo";
        Elf elfo = new Elf(name);
        Bow bow = new Bow("Bow");
        Ring ring = new Ring("Ring");
        elfo.Bow = bow;
        elfo.Ring = ring;
      
        int attack = bow.AttackValue + ring.AttackValue;
        Assert.AreEqual(attack, elfo.AttackValue);
      
    }


    [Test]
    public void TestDeffenseValue()
    {
        const string name = "Elfo";
        Elf elfo = new Elf(name);
        Bow bow = new Bow("Bow");
        Ring ring = new Ring("Ring");
        elfo.Bow = bow;
        elfo.Ring = ring;
      
        int defense = bow.DefenseValue + ring.DefenseValue;
        Assert.AreEqual(defense, elfo.DefenseValue);  
    }


    
}