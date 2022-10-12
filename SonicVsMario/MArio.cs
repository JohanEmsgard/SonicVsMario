using System;

public class Mario
{
    public string name = "Mario";

    public int Mhp = 100;


    private bool MarioAlive;


    public int MarioAttack;
    public void Attack(Sonic target)
    {
        target.Shp -= 2;

    }

    public void SW()
    {
        {
            Console.WriteLine($"Mario lost Sonic wins");
            MarioAlive = false;
        }
    }

    private int strength;

    public int Strength
    {
        get 
        {
            return Strength;
        }
        set
        {
            strength = value;
            if (strength < 100)
            strength = 120;

        }
    }




}
