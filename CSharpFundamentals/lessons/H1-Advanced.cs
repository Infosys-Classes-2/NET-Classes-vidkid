 // Parallel Programming: TPL (Task Parallel Library)
 // Asynchronous Programming: async, await
 using System;
 using System.Threading;
 using System.Threading.Tasks;
 using System.Drawing;



// public class LearnParallel
// {
//     int[] numbers = {43, 73, 72, 82, 48, 26};
//     public void Do()
//     {
//        //Sequential version
//        foreach (var num in numbers)
//        {
//             Thread.Sleep(1000);
//             var f = GetFactorial(num);
//             Console.WriteLine($"{num}! = {f}");
//        }
//     }

//     //Parallel version
//     Parallel.Foreach(numbers, num => {  
//          var f = GetFactorial(num);
//             Console.WriteLine($"{num}! = {f}");

//     });

//     private long GetFactorial(long n)
//     {
//         if (n == 0 || n == 1)
//         return 1;
//         return n * GetFactorial(n -1);
//     }
// }

public class LearnAsync 
{
    async Task GetSomething()
    {
        await GetSomething1();
        await GetSomething2();
    }

    private async Task GetSomething2()
    {
        await Task.Delay(3000);
    }
    private async Task GetSomething1()
    {

    }
}