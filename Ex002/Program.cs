// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Comparison result: ");
if (firstNumber < secondNumber)
{
    Console.WriteLine(firstNumber +" < " + secondNumber);
    Console.WriteLine("MAX = "+secondNumber);
}    
if (firstNumber > secondNumber)
{   Console.WriteLine(firstNumber +" > " + secondNumber);
    Console.WriteLine("MAX = "+firstNumber);
}    
if (firstNumber == secondNumber)
{
    Console.WriteLine(firstNumber +" = " + secondNumber);
    Console.WriteLine("Numbers are equal");    
}