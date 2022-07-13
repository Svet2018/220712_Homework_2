// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 7 -> да 1 -> нет

/* 1 Решение задачи:

Console.WriteLine("Введите в числовом виде день недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays= {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int weekDayaArrayLenght = weekDays.Length;
int correctNum = num - 1;
string answer = weekDays[correctNum];

if (num == 6 ^ num == 7)
{
    System.Console.WriteLine($"Вы ввели число - {num}, что соответствует такому дню недели как - {weekDays[correctNum]} и является выходным днем");
}
else
{
    System.Console.WriteLine($"Вы ввели число - {num}, что соответствует такому дню недели как - {weekDays[correctNum]} и является рабочим днем");
}

*/





