using System;

public class Mario
{
    public string name;

    public int Mhp;

    private bool MarioAlive;

    //public int MarioAttack;

    public void Attack(Sonic target)
    {
        target.Shp -= 2;

    }

    public void SW()
    {
        Mhp --;
        if (Mhp <= 0)
        {
            Console.WriteLine("Mario lost Sonic wins");
            MarioAlive = false;
        }
    }



}
