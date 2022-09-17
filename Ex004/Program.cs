// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Input first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input thrid number:");
int thridNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;
if (firstNumber < secondNumber)
    maxNumber = secondNumber;
if (maxNumber < thridNumber)    
    maxNumber = thridNumber;
       
Console.WriteLine("MAX number is: "+ maxNumber);