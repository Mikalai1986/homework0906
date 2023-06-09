// Homework
/* Задача2: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
*/
Console.Write("Ведите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
    Console.Write( number1 +  " равно " + number2);
    else
        if (number1 > number2)
         Console.Write( number1 +  " max ");
    else
    Console.Write(number2 +" max ");    