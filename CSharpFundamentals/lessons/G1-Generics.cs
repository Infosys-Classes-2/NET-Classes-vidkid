// Type Parameters

using System;

public class Generic
{
     public void Print(string greeting)
    {
        Console.WriteLine(greeting);
    }

    public void Print<T>(T x)
    {
        Console.WriteLine(x);
    }

     public void Print1<K>(K f)
    {
        Console.WriteLine(f);
    }

}



class Test4
{
    void Test()
    {
        Generic g = new();
        g.Print("hi There");
        g.Print<float>(73237.33f);
        g.Print<Boolean>(true);
    }
}