using Library;

namespace LibraryTests;

public class TestWizard
{

    [Test]
    public void TestAttackValue()
    {
        const string name1 = "Mago 1";
        const string name2 = "Mago 2";
        Wizard wizard1= new Wizard(name1);
        Wizard wizard2= new Wizard(name2);
        wizard1.SpellBook = new SpellBook("SpellBook");
        wizard2.Cloak = new Cloak("Cloak");
        int initialhealth = wizard2.Health;
        wizard1.AttackOther(wizard2);
        int expecteddamage = wizard1.GetAttackValue() - wizard2.GetDefenseValue();
        int expectedhealth = initialhealth - expecteddamage;
        Assert.AreEqual(expectedhealth, wizard2.Health);   

    }
}