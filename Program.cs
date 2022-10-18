using System;

Console.Write("Enter your name: ");
string myName = Console.ReadLine();
string greeting = $"Hello {myName}";
Console.WriteLine(greeting);

int keschaAge = 2;

Console.Write("Enter your age: ");
string age = Console.ReadLine();
int myAge = Convert.ToInt32(age);
int sum = myAge - keschaAge;
Console.WriteLine($"Yosh orasidagi tafovut {myAge - keschaAge} ga teng");

Console.WriteLine($"You are older than Kescha: {sum > 0}");
Console.WriteLine($"You are younger than Kescha: {sum < 0}");
Console.WriteLine($"You are older or equal than Kescha: {sum >= 0}");
Console.WriteLine($"You are younger than Kescha: {sum <= 0}");
Console.WriteLine($"You are equal or older than Kescha: {sum != 0}");