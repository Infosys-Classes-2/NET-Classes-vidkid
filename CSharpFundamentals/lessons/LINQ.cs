//Language Integrated Query (LinQ)
using System;
using System.Linq;
using System.Collections.Generic;


public class LinQ
{
    int[] numbers = {2 ,4 ,5 ,7, 9, 12 , 13 ,15 , 20 ,22, 33, 43 ,89};

    public void LearnLINQ()
    {
        //1. Fetch all even numbers on "numbers".
        // Method Syntax

        // List<int> evenNumbers = new();

        // foreach (var item in numbers)
        // {
        //     if (n % 2 == 0)
        //     evenNumbers.Add(item);
                
        // }

        var evenNumbers = numbers.Where(n => n % 2 ==0);

        //Expression Syntax
        evenNumbers = from n in numbers
                    where n % 2 ==0
                    select n;

        //2. Fetch all odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);
    
        // 3. Fetch all Perfect sqaures      

        var perfectSquares = numbers.Where(x => IsPerfectSquare(x));

        //4. Convert all numbers in "numbers" to their cubes
        var cubes = numbers.Select(x => x * x * x);

        //5. Get Squares of all even "numbers"

        var evensquares = numbers.Where(n => n % 2 == 0 ).Select(y => y * y);
    }

        public bool IsPerfectSquare(int n)
        {
            var sr = Math.Sqrt(n);
            var product = sr * sr;
            return product == n;
        }       
    }

