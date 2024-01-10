// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//read data from user
//read value v1
Console.Write("Enter integer 1 ");
int v1 = int.Parse(Console.ReadLine());
Console.Write("Enter integer 2 ");
//read value v2
int v2 = int.Parse(Console.ReadLine());
//addthem
int total = v1 + v2;
Console.WriteLine($"{v1} + {v2} = {total}");

//---------------------------------------------------
//read strings: first name, last name
Console.Write("\n\nEnter first name: ");
string firstname = Console.ReadLine();

Console.Write("\nEnter last name: ");
string lastname = Console.ReadLine();

Console.WriteLine($"your name is: {firstname} {lastname}");


//dummy read to pause
Console.WriteLine("\n\nhit <return> key to exit");
Console.ReadLine();
