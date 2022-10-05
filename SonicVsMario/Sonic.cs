using System;


public class Sonic
{
    public string name;

    public int speed;

    public int Shp = 100;

    private bool SonicAlive;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }

     public void MW()
    {
        {
            
            Console.WriteLine("Sonic lost Mario wins");
            SonicAlive = false;
        }


    }


}
