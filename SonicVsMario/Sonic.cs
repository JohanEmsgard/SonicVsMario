using System;


public class Sonic
{
    public string name = "Sonic";

    public int speed = 200;

    public int Shp = 100;

    private bool SonicAlive;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }

    public void Run()
    {
        speed += 10;
    }

     public void MW()
    {
        {
            
            Console.WriteLine($"Sonic lost Mario wins");
            SonicAlive = false;
        }


    }


}
