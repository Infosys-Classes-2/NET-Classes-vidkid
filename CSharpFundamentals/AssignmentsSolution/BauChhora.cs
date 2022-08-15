  using System;
  public class Hajurbau// base class 1
  {
      public virtual void RameshDad()
      {
          Console.WriteLine("Ma ko ho?");
      }
  }
  public class Hajuraama// base class 2
  {
      public virtual void RupaMom() 
  {
      Console.WriteLine("Ma ko ho?");
  }
  }
  public class Dad : Hajuraama// child class 1
  {
      public override void RupaMom()
      {
          Console.WriteLine("I am Rupa Mommy.");
      }
  }
  public class Mom : Hajurbau// child class 2
  {
      public override void RameshDad()

      {
          Console.WriteLine("I am Ramesh Dad.");
      }
  }
 class Naati : Dad // grand child
  {
      protected void grandchild()
      {
          Console.WriteLine("I am Grandchild.");
      }
  }
  