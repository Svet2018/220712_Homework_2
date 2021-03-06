//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

// 1 Решение задачи с помощью ввода числа в консоль, используется  тип данных - int:

/*
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 100 | num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число. Введите трехзначное число.");
    num = Convert.ToInt32(Console.ReadLine());
}

int answer = (num / 10) % 10;


System.Console.WriteLine($"Вы ввели трехзначное число - {num}, второй цифрой этого числа является - {answer}");
*/



//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

// 2 Решение задачи с использованием созданного метода SecondNum():

/*
int SecondNum(int num)
{
    int answer;
    answer = (num / 10) % 10;
    if (num < 1000 & num > 99)
    {
        Console.WriteLine($"Было дано трехзначное число - {num}, второй цифрой этого числа является - {answer}.");
    }
    else
    {
        Console.WriteLine($"Было дано число - {num}, которое не является трехзначным числом.");
    }
    return answer;
}

SecondNum(23);
SecondNum(231);
SecondNum(398);
SecondNum(98790);
*/


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

// 3.Решение задачи с помощью ввода числа в консоль, используется  тип данных - string.

/*
Console.WriteLine("Введите трехзначное число: ");
string num = Console.ReadLine();

int strLenght = num.Length;

while (strLenght != 3)
{
    if (num.Length != 3)
    {
    Console.WriteLine("Вы ввели не трехзначное число. Введите трехзначное число.");
    num = Console.ReadLine();
    }
    else
    {
        string answer = num.Substring(1, 1);
        System.Console.WriteLine($"Вы ввели трехзначное число - {num}, второй цифрой этого числа является - {answer}");
        break;
    }
}
*/


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

// 4 Решение задачи с использованием созданного метода SecondNum():

/*
void SecondNum(int num)
{
    string number = Convert.ToString(num);
    int answer;
    //answer = number.Substring(1, 1);
    answer = Convert.ToInt32(number.Substring(1, 1));
    if (number.Length != 3)
    {
        Console.WriteLine($"Было дано число - {num}, которое не является трехзначным числом. Но второй цифрой данного числа является - {answer}");
    }
    else
    {
        System.Console.WriteLine($"Было дано число трехзначное число - {num}, второй цифрой этого числа является - {answer}");
    }    
}

SecondNum(23);
SecondNum(231);
SecondNum(398);
SecondNum(98790);
*/