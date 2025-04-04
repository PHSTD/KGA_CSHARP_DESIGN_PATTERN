namespace KGA_CSHARP_DESIGN_PATTERN;

class Program
{
    static void Main(string[] args)
    {
        WeaponFactory weaponFactory = new WeaponFactory();

        WeaponFactory cgm1 = weaponFactory.Create("철검", "RARE");
        WeaponFactory cgm2 = weaponFactory.Create("철검", "LEGENDARY");
        WeaponFactory cgm3 = weaponFactory.Create("철검");
        WeaponFactory wd = weaponFactory.Create("나무창");
        WeaponFactory sg = weaponFactory.Create("쇠도끼");
        
        Console.WriteLine(cgm1.name);
        Console.WriteLine(cgm1.power);
        Console.WriteLine(cgm2.power);
        Console.WriteLine(cgm3.power);
        Console.WriteLine(cgm1.range);
        Console.WriteLine(wd.name);
        Console.WriteLine(wd.power);
        Console.WriteLine(wd.range);
        Console.WriteLine(sg.name);
        Console.WriteLine(sg.power);
        Console.WriteLine(sg.range);
        
        Console.WriteLine("========================================");

        AnimalBuilder chickeAnimalBuilder = new AnimalBuilder();
        chickeAnimalBuilder
            .SetName("닭")
            .SetEatName("일반사료");

        AnimalBuilder.Animal chicken = chickeAnimalBuilder.Build();
        Console.WriteLine($"{chicken.name} {chicken.eatName} {chicken.sound} {chicken.rank} {chicken.products}");
        
        AnimalBuilder chickeAnimalBuilder1 = new AnimalBuilder("닭", "황금사료");
        
        AnimalBuilder.Animal chicken1 = chickeAnimalBuilder1.Build();
        Console.WriteLine($"{chicken1.name} {chicken1.eatName} {chicken1.sound} {chicken1.rank} {chicken1.products}");
    }
}