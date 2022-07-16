﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 7 -> да 1 -> нет

// 1 Решение задачи:

/*

Console.WriteLine("Введите в числовом виде день недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays= {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int correctNum = num - 1;

if (num == 6 ^ num == 7)
{
    System.Console.WriteLine($"Вы ввели число - {num}, что соответствует такому дню недели как - {weekDays[correctNum]} и является выходным днем");
}
else
{
    System.Console.WriteLine($"Вы ввели число - {num}, что соответствует такому дню недели как - {weekDays[correctNum]} и является рабочим днем");
}

*/


// 2 Решение задачи с помощью метода dayOfWeek:

/*

void dayOfWeek(int day)
{
    string[] weekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    string answer = weekDays[day - 1];
    if (day == 6 ^ day == 7)
    {
        System.Console.WriteLine($"Дано число - {day}, что соответствует такому дню недели как - {answer} и является выходным днем");
    }
        else
    {
        System.Console.WriteLine($"Дано число - {day}, что соответствует такому дню недели как - {answer} и является рабочим днем");
    }
}

dayOfWeek(1);
dayOfWeek(2);
dayOfWeek(3);
dayOfWeek(4);
dayOfWeek(5);
dayOfWeek(6);
dayOfWeek(7);

*/






