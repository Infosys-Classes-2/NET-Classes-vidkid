using System;

// Console.WriteLine("your name: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello, {name}");
// Console.WriteLine("yourfullname");
// var yourfullname = Console.ReadLine();
// var len = yourfullname.IndexOf(" ");
// var firstname = yourfullname.Substring(0, len);
// Console.WriteLine($"Hello, {firstname}");

// class work 1

//  Console.WriteLine("enter your name");
//  string name =  Console.ReadLine();

//  Console.WriteLine(name.ToUpper());



//  class work 2

// Console.WriteLine("enter meter value: ");
// var length = Console.ReadLine();
// var lengthnumber = double.Parse(length);
// var feets = lengthnumber * 3.288;
// Console.WriteLine($"{lengthnumber} is {feets}");



// //class work 3

// Console.WriteLine("Enter the Radius: ");
// var r = Console.ReadLine();
// var radius = Convert.ToInt32(r);
// var p = 3.1428;
// var area = p *  radius * radius;
// Console.WriteLine($"The area of circle is: {area}");



// class work 4


  int years, months, weeks, days, num;
  Console.Write("Enter number of days: ");
  num = Convert.ToInt32(Console.ReadLine());
  years = num / 365;
  months = (num%365)/30;
  weeks = ((num % 365)%30) / 7;
  days  = ((num % 365)%30)% 7;
  Console.WriteLine("Years : " + years);
  Console.WriteLine("Months :" + months);
  Console.WriteLine("Weeks : " + weeks);
  Console.WriteLine("Days  : " + days ); 


