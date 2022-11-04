/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

bool stop = false;
int num = 0;
int abzero = 0;

while(!stop) // !false = true; !true = false;
{
    Console.WriteLine("Введите число");
    num = int.Parse(Console.ReadLine() ?? "");
    if(num > 0)
    abzero++;

    Console.WriteLine("Продолжить вводить числа? y/n");
    string result = Console.ReadLine();
    if(result == "y")
        stop = false;
    else
        stop = true;
    }
    Console.WriteLine($"Количество чисел, введенных пользователем, которые больше 0 = {abzero}");