//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


while (num < 100 ^ num > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число. Введите трехзначное число.");
    num = Convert.ToInt32(Console.ReadLine());
}

int answer = (num / 10) % 10;


System.Console.WriteLine($"Вы ввели трехзначное число - {num}, второй цифрой этого числа является - {answer}");
