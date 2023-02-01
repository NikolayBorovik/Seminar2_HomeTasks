// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.WriteLine("Enter your 1st number: ");
string? strNumber = Console.ReadLine();
int numberN = int.Parse(strNumber);

if(numberN < 100 || numberN > 999)
{
    System.Console.WriteLine("You have enetered a wrong number");
}

int number1  = numberN%100;
int number2 = number1%10;
int result = (number1-number2)/10;

System.Console.WriteLine(result);