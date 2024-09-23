using Library;

namespace LibraryTests;

public class TestWizard
{

    [Test]
    public void TestAttackValue()
    {
        const string name = "Mago";
        Wizard wizard = new Wizard(name);
        SpellBook spellBook = new SpellBook("SpellBook");
        Cloak cloak = new Cloak("Cloak");
        wizard.SpellBook = spellBook;
        wizard.Cloak = cloak;
      
        int attack = spellBook.AttackValue + cloak.AttackValue;
        Assert.AreEqual(attack, wizard.AttackValue);
      
    }


    [Test]
    public void TestDeffenseValue()
    {
       
        const string name = "Mago";
        Wizard wizard = new Wizard(name);
        SpellBook spellBook = new SpellBook("SpellBook");
        Cloak cloak = new Cloak("Cloak");
        wizard.SpellBook = spellBook;
        wizard.Cloak = cloak;
      
        int defense = spellBook.DefenseValue + cloak.DefenseValue;
        Assert.AreEqual(defense, wizard.DefenseValue);  
    }
    [Test]
    public void TestAttackDwarf()
    {
        const string name = "Mago";
        Wizard wizard = new Wizard(name);
        SpellBook spellBook = new SpellBook("SpellBook");
        Cloak cloak = new Cloak("Cloak");
        wizard.SpellBook = spellBook;
        wizard.Cloak = cloak;
        const string name1 = "Enano";
        Dwarf dwarf = new Dwarf(name1);
        Shield shield = new Shield("Shield");
        Hammer hammer = new Hammer("Hammer");
        dwarf.Hammer = hammer;
        dwarf.Shield = shield;
        int expectedhealth = wizard.Health - (hammer.AttackValue - cloak.DefenseValue);
        wizard.AttackOther(dwarf);
        Assert.AreEqual(wizard.Health, expectedhealth);
    }
    
    [Test]
    public void TestAttackWizard()
    {
        const string name1 = "Mago";
        Wizard wizard = new Wizard(name1);
        SpellBook spellBook = new SpellBook("SpellBook");
        Cloak cloak = new Cloak("Cloak");
        wizard.SpellBook = spellBook;
        wizard.Cloak = cloak;
        const string name = "Elfo";
        Elf elfo = new Elf(name);
        Bow bow = new Bow("Bow");
        Ring ring = new Ring("Ring");
        elfo.Bow = bow;
        elfo.Ring = ring;
        int expectedhealth = wizard.Health - (bow.AttackValue - cloak.DefenseValue);
        wizard.AttackOther(elfo);
        Assert.AreEqual(wizard.Health, expectedhealth);
    }
}