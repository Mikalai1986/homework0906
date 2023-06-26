/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


int MathPow(int A, int B)
{int Res = A;
    for (int i = 1; i < B; i++)
    Res = Res*A;
return Res;
}
Console.WriteLine("Введите число А");
int A1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень B");
int B1 = int.Parse(Console.ReadLine()!);
int result = MathPow(A1, B1);
Console.WriteLine($"число {A1} в степени {B1} = {result}");
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


int Summa(int A)
{
    int sum = 0;
    while (A>0)
    {sum = sum + A % 10;
    A = A / 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int A1 = int.Parse(Console.ReadLine()!);
int res = Summa(A1);
Console.WriteLine($"Сумма цифр числа {A1} равна {res}");
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
    // array[i] = new Random().Next(min, max + 1)
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}
int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
