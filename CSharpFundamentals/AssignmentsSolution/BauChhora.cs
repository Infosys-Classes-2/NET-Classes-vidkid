using System;

public class Hajurbau // base class 1
{
    public void RupaMom()
    {
        Console.WriteLine("Ma ko ho?");
    }
}
public class Hajuraama // base class 2
{
    public void RameshDad() 
{
    Console.WriteLine("Ma ko ho?");
}
}
public class Dad : Hajuraama // child class 1
{
    public void RameshDad()
    {
        Console.WriteLine("I am Ramesh Daddy.");
    }
public class Mom : Hajurbau // child class 2
{
    public void RupaMom()
    {
        Console.WriteLine("I am Rupa Mommy.");
    }
}
protected class Naati : Dad // grand child
{
    protected void grandchild()
    {
        Console.WriteLine("I am Grandchild.");
    }
}

}