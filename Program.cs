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
 Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным 
(делится ли оно на два без остатка)

 Console.Write("Ведите число:");
int num = Convert.ToInt32(Console.ReadLine());
int del = num % 2;
if (del == 0)
    Console.WriteLine("Число "+ num + " - четное");
else Console.WriteLine("Число "+ num + " - нечетное");
Задача 8: Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа 
от 1 до N

Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
    {Console.Write(count + ", ");
    count=count+2;}
//Console.Write(count);
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/