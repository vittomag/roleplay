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
    [Test]
    public void TestAttackDwarf()
    {
        const string name = "Elfo";
        Elf elfo = new Elf(name);
        Bow bow = new Bow("Bow");
        Ring ring = new Ring("Ring");
        elfo.Bow = bow;
        elfo.Ring = ring;
        const string name1 = "Enano";
        Dwarf dwarf = new Dwarf(name1);
        Shield shield = new Shield("Shield");
        Hammer hammer = new Hammer("Hammer");
        dwarf.Hammer = hammer;
        dwarf.Shield = shield;
        int expectedhealth = elfo.Health - (hammer.AttackValue - ring.DefenseValue);
        elfo.AttackOther(dwarf);
        Assert.AreEqual(elfo.Health, expectedhealth);
    }


}