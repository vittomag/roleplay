using Library;

namespace LibraryTests;

public class TestDwarf
{

    [Test]
    public void TestAttackValue()
    {
        const string name1 = "Enano 1";
        const string name2 = "Enano 2";
        Dwarf dwarf1 = new Dwarf(name1);
        Dwarf dwarf2 = new Dwarf(name2);
        dwarf1.Hammer = new Hammer("Hammer");
        dwarf2.Shield = new Shield("Shield");
        int initialhealth = dwarf2.Health;
        dwarf1.AttackOther(dwarf2);
        int expecteddamage = dwarf1.GetAttackvalue() - dwarf2.GetDefensevalue();
        int expectedhealth = initialhealth - expecteddamage;
        Assert.AreEqual(expectedhealth, dwarf2.Health);   

    }
}