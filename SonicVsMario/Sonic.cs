using System;


public class Sonic
{
    public string name = "Sonic";

    public int SonicAttack;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }

    //public void Run()
    //{
        //speed += 10;
    //}
    private bool SonicAlive;

     public void MW()
    {
        {
            
            Console.WriteLine($"Sonic lost Mario wins");
            SonicAlive = false;
        }


    }

        private int speed;

    public int Shp = 100;

    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
            if (speed < 90)
            {
                speed = 100;
            }
        }

    }


}
