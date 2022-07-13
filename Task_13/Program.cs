// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 78 -> третьей цифры нет 32679 -> 6

/* 1 Решение задачи:


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


while (num < 100 ^ num > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число. Введите трехзначное число.");
    num = Convert.ToInt32(Console.ReadLine());
}

int answer = (num / 10) % 10;


System.Console.WriteLine($"Вы ввели трехзначное число - {num}, второй цифрой этого числа является - {answer}");

*/


// 2 Решение задачи:
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 78 -> третьей цифры нет 32679 -> 6



Console.WriteLine("Введите число: ");
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

