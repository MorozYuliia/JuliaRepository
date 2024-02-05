// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, 123");
byte myByteNumber = 30;
short myShort = 15123;
int myIntNumber = 7;
bool myBoolValue = true;
long myLongNumber = 114545897;
float myFloat = 125.89f;
double myDouble = 178.25575d;
decimal myDecimal = 1457.455898998979m;


Console.WriteLine(myByteNumber);
Console.WriteLine(myShort);
Console.WriteLine(myIntNumber);
Console.WriteLine(myBoolValue);
Console.WriteLine(myLongNumber);
Console.WriteLine(myFloat);
Console.WriteLine(myDouble);
Console.WriteLine(myDecimal);
Console.WriteLine("Calculations");
Console.WriteLine(myShort + myByteNumber);
Console.WriteLine(myIntNumber - myByteNumber);
Console.WriteLine(myFloat * myDouble);
Console.WriteLine(myLongNumber / myDecimal);


Console.WriteLine("Math operations");
int x = 42;
int y = 16;
Console.WriteLine(-6*x^3+5*x^2-10*x+15);
Console.WriteLine(Math.Abs(x)*Math.Sin(x));
Console.WriteLine(2*Math.PI*x);
Console.WriteLine(Math.Max(x,y));

Console.WriteLine("Extra with Dates");
var now = DateTime.Now;
var newYear2024 = new DateTime(2024,01,01);
var newYear2025 = new DateTime(2025,01,01);
var passedFromNY = now - newYear2024;
var passedFromNYInDays = passedFromNY.Days;
var leftToNY = newYear2025 - now;
var leftToNYInDays = leftToNY.Days;
Console.WriteLine($"PassedFromNYInDays: {passedFromNYInDays}");
Console.WriteLine($"LeftToNYInDays: {leftToNYInDays}");



