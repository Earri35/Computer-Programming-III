// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Methods and Arrays!/List");

//empty array
int[] grades1 = new int[12];
int[] grades2 = { 88, 9, 55, 76, 87, 4 };
double avg2 = getAverage(grades2);
Console.WriteLine($"avg2 = {avg2:F1}");


Console.WriteLine("\n\nHit <return> to exit");
//dummy pause
Console.ReadLine();//cuases the app to wait until the user hit the return key

//method that takes an array and  displays it

void DisplayArray(int[] array)
{
    Console.WriteLine("\nDisplaying array:");
    foreach (int value in array) { 
        Console.WriteLine(value);
    }
}
double getAverage(int[] array)
{
    double sum = 0;
    foreach(double value in array)
    {
        sum += value;
    }
    return sum/array.Length;
}