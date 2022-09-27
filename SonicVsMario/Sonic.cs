using System;


public class Sonic
{
    public string name;

    public int speed;

    public int Shp;

    public void Attack(Mario target)
    {
        target.Mhp -= 3;
    }


}
