// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

System.Console.WriteLine("Enter your number: ");
string? strNumber = Console.ReadLine();
int number = int.Parse(strNumber);

if(number >7 || number <1)
{
    System.Console.WriteLine("You have entered a wrong number");
}
else if(number == 6 || number == 7)
{
    System.Console.WriteLine("It's a weekend!!!");
}
else
{
    System.Console.WriteLine("It's NOT a weekend :(");
}
