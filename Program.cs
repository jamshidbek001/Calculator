using System;

Console.Write("Enter your name: ");
string myName = Console.ReadLine();
string greeting = $"Hello {myName}";
Console.WriteLine(greeting);

int keschaAge = 2;

Console.Write("Enter your age: ");
string age = Console.ReadLine();
int myAge = Convert.ToInt32(age);
Console.WriteLine($"Yosh orasidagi tafovut {myAge - keschaAge} ga teng");

