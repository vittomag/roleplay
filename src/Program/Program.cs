using Library;

Elf elf = new Elf("Elfo");
elf.Bow = new Bow("Bow");
elf.Ring = new Ring("Ring");
Dwarf dwarf = new Dwarf("Enano");
dwarf.Shield = new Shield("Shield");
dwarf.Hammer = new Hammer("Hammer");

Console.WriteLine($"Elfo tiene {elf.Health} de vida");
Console.WriteLine($"Enano ataca a Elfo con {dwarf.AttackValue} de ataque");
elf.AttackOther(dwarf);
Console.WriteLine($"Elfo tiene {elf.Health} de vida");
elf.Heal();
Console.WriteLine($"Elfo tiene {elf.Health} de vida");