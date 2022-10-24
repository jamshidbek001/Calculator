using System;
using CALCULATOR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculatr calculatr = new Calculatr();

        security.CheckPassword();
        calculatr.GetInputs();




        string message =
                    !(calculatr.IsFirstNumberPositive())
                    ? "Fist number is not positive"
                    : "First number is not negative";

        Console.WriteLine(message);

        calculatr.CompareInputs();

        string result = calculatr.Calculate();
        Console.WriteLine(result);

        calculatr.PrintEventNumbers();
        calculatr.PrintMultiplicationTable();






        // string result = operation switch
        // {
        //     "+" => $"{fNumber} + {sNumber} = {fNumber + sNumber}",
        //     "-" => $"{fNumber} - {sNumber} = {fNumber - sNumber}",
        //     "/" => $"{fNumber} / {sNumber} = {fNumber / sNumber}",
        //     "*" => $"{fNumber} * {sNumber} = {fNumber * sNumber}",
        //     "%" => $"{fNumber} % {sNumber} = {fNumber % sNumber}",
        //     _ => "Operation not found"
        // };

        // Console.WriteLine(result);








    }
}