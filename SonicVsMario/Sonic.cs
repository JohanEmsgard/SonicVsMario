using System;


public class Sonic
{
    public string name = "Sonic";


    private int speed;

    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
            if (speed < 0)
            {
                speed = 100;
            }
        }

    }


    public int Shp{get; set;}

    private bool SonicAlive;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }

    //public void Run()
    //{
        //speed += 10;
    //}

     public void MW()
    {
        {
            
            Console.WriteLine($"Sonic lost Mario wins");
            SonicAlive = false;
        }


    }


}
