// Homework
/* Задача2: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше

Console.Write("Ведите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
    Console.Write("A="+ number1 +  " равно B=" + number2);
    else
        if (number1 > number2)
         Console.Write( "A=" + number1 + ", B=" + number2 +  " ->  max=" + number1);
    else
    Console.Write( "A=" + number1 + ", B=" + number2 +  " ->  max=" + number2);   
    */
    // Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
    Console.Write("Ведите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;

if (number3 > max)
    max = number3;
Console.WriteLine(number1 + ", " + number2 + ", " + number3 + "->" + max);