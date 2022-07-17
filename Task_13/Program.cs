// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 78 -> третьей цифры нет 32679 -> 6

// 1 Решение задачи с помощью типа int:

/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number;

while (num > 0 & num <100)
{
    Console.WriteLine($"Вы ввели число {num}, у которого нет третьей цифры. Введите другое число.");
    num = Convert.ToInt32(Console.ReadLine());
}

number = num;

while (number > 999)
{
 number = number / 10;
}

number = number % 10;

System.Console.WriteLine($"Вы ввели число {num}, третьей цифрой данного числа является - {number}");

*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 78 -> третьей цифры нет 32679 -> 6

// 2 Решение задачи с помощью типа string:

/*
Console.WriteLine("Введите число:");
string num = Console.ReadLine();

int strLenght = num.Length;

if (strLenght < 3)
{
    Console.WriteLine($"Вы ввели число - {num}, которое не имеет третью цифру.");
}
else
{
    string answer = num.Substring(2, 1);
    System.Console.WriteLine($"Вы ввели число - {num}, третьей цифрой этого числа является - {answer}");       
}
*/
