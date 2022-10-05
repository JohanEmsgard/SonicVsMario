Console.WriteLine("Sonic: Alright Mario Let's settle this");
Console.ReadLine();
Console.WriteLine("Mario: Let's:a go");
Console.ReadLine();

Sonic sonic = new Sonic();
Mario mario = new Mario();
//name.Sonic = "Sonic";
//name.Mario = "Mario";

while (sonic.Shp > 0 && mario.Mhp > 0)
{
    Console.WriteLine("Sonic and Mario Attack eachother");
    sonic.Attack(mario);
    mario.Attack(sonic);

    Console.ReadKey();

    if (sonic.Shp == 0)
    {
        Console.WriteLine($"{sonic.MW}");
    }

    else if (mario.Mhp == 0)
    {
        Console.WriteLine($"{mario.SW}");

    }

}


Console.WriteLine("Battle Over");
Console.WriteLine("Press enter to exit");



Console.ReadLine();
