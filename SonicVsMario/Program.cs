Console.WriteLine("Sonic: Alright Mario Let's settle this");
Console.ReadLine();
Console.WriteLine("Mario: Let's:a go");
Console.ReadLine();

Sonic sonic = new Sonic();
Mario mario = new Mario();

int Shp = 100;

int Mhp = 100;

while(SonicAlive() == true)
{
    Console.Clear();

}

Console.WriteLine("Sonic and Mario Attack eachother");




sonic.Attack(mario);
mario.Attack(sonic);

Console.WriteLine($"{sonic.MW}");

Console.WriteLine($"{mario.SW}");




Console.ReadLine();
