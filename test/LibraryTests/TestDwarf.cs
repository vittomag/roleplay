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
    [Test]
    public void TestAttackElf()
    {
        const string name1 = "Enano";
        Dwarf dwarf = new Dwarf(name1);
        Shield shield = new Shield("Shield");
        Hammer hammer = new Hammer("Hammer");
        dwarf.Hammer = hammer;
        dwarf.Shield = shield;
        const string name = "Elfo";
        Elf elfo = new Elf(name);
        Bow bow = new Bow("Bow");
        Ring ring = new Ring("Ring");
        elfo.Bow = bow;
        elfo.Ring = ring;
        int expectedhealth = dwarf.Health - (bow.AttackValue - shield.DefenseValue);
        dwarf.AttackOther(elfo);
        Assert.AreEqual(dwarf.Health, expectedhealth);
    }
    
    [Test]
    public void TestAttackWizard()
    {
        const string name = "Enano";
        Dwarf dwarf = new Dwarf(name);
        Hammer hammer = new Hammer("Hammer");
        Shield shield = new Shield("Shield");
        dwarf.Hammer = hammer;
        dwarf.Shield = shield;
        const string name1 = "Mago";
        Wizard wizard = new Wizard(name1);
        SpellBook spellBook = new SpellBook("SpellBook");
        Cloak cloak = new Cloak("Cloak");
        wizard.SpellBook = spellBook;
        wizard.Cloak = cloak;
        int expectedhealth = dwarf.Health - (spellBook.AttackValue - shield.DefenseValue);
        dwarf.AttackOther(wizard);
        Assert.AreEqual(dwarf.Health, expectedhealth);
    }

}