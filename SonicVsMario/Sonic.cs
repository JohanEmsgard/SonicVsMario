using System;


public class Sonic
{
    public string name;

    public int speed;

    public int Shp;

    private bool SonicAlive;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }

    public void MW()
    {
        if (Shp <= 0)
        {
            Console.WriteLine("Sonic lost Mario wins");
            SonicAlive = false;
        }


    }


}
