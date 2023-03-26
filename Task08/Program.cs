// Задача 6: Напишите программу, которая на вход принимает число
//  (N), а на выходе показывает все чётные числа от 1 до N.

// Вариант 1

// Console.Write("Input number N > 2: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count <= number)
// {
// Console.Write($"{count}  ");
// count = count + 2;
// }
// Вариант 2

Console.Write("Input number N > 2: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    Console.Write($"{count}  ");
    count ++;
}