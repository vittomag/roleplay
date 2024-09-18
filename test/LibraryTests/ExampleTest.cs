namespace LibraryTests;
using Library;

public class Tests
{

    [Test]
    public void TestAttackValue()
    {
        const string name1 = "Elgifo 1";
        const string name2 = "Elfo 2";
        Elf elf1 = new Elf(name1);
        Elf elf2 = new Elf(name2);
        elf1.Bow = new Bow("Bow");
        elf2.Ring = new Ring("Ring");
        int initialhealth = elf2.Health;
        elf1.AttackOther(elf2);
        int expecteddamage = elf1.GetAttackvalue() - elf2.GetDefensevalue();
        int expectedhealth = initialhealth - expecteddamage;
        Assert.AreEqual(expectedhealth, elf2.Health);   

    }
}