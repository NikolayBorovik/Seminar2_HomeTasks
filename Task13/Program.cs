// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Random rnd = new Random();
int number = rnd.Next();
System.Console.WriteLine(number);

if(number <100)
{
    System.Console.WriteLine("There is no 3rd digit");
}

if(number >= 100)
{
    while(number > 999)
{
    number = number/10;
}
}
int result = number%10;

System.Console.WriteLine(result);