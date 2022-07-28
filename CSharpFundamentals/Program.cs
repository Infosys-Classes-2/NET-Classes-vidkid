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

Console.WriteLine("Enter days: ");
var d = Console.ReadLine();
var days = Convert.ToInt32(d);
var year = days/365;
var month = days/12;
var week = days/7;
Console.WriteLine($"The year is {year}, month is {month}, week is {week} and days is {days}");
