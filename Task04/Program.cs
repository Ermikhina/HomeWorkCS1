// Задача 4: Напишите программу,
// которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 && number2 == number3)
{
    Console.WriteLine("All numbers are equal");
}
else
if (number1 > number2)
    {
    if (number1 > number3)
        {
            Console.WriteLine($"{number1} is maximum");
        }
        else
            {Console.WriteLine($"{number3} is maximum");}
            }
    else
        if (number2 > number3)
            {
            Console.WriteLine($"{number2} is maximum");
            }
        else
            {
            Console.WriteLine($"{number3} is maximum");
            }
            
