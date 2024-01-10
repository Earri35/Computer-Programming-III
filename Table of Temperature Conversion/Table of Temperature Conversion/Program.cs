
List<Double> fahrenheit = new List<Double>();
Double C;
for(double i = 0;i < 251; i++)
{
    fahrenheit.Add(i);
}
List<Double> Celsius = new List<Double>();
foreach(int value in fahrenheit)
{
    C = (Double)5 / 9 * (value - 32);
    Celsius.Add(C);
}
DisplayArray(fahrenheit,Celsius);


Console.WriteLine("\n\nPress <return> to exit console");
Console.ReadLine();

void DisplayArray(List<Double> array,List<Double> array2)
{
    Console.WriteLine("\nConverting Fahrenheit to Celsius:");
    for(int i = 0; i < 251; i++)
    {
        Console.WriteLine($"{array[i]} F -> {array2[i]}C");
    }
}
