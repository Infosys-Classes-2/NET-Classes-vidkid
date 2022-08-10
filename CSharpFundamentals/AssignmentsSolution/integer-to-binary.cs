using System;

namespace Integer_To_Binary
{
    class Program
    {
        static void Main (string [] args)
        {
            int n;
            Console.WriteLine("Enter the integer value");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; n<2 ; i++)
            {
                var r=n%2;
                n=n/2;
                
                
            

            }
                Console.WriteLine(n);
            


        }

    }

}