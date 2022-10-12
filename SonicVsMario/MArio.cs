using System;

public class Mario
{
    public string name = "Mario";

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

    private int mhp;

    public int Mhp
    {
        get
        {
             return mhp;

        }
        set
        {
            mhp = value;
            if (mhp < 0)
            {
                mhp = 0;
            }
        }

    }

    private bool MarioAlive;

    //public int MarioAttack;

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



}
