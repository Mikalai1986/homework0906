/*Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int chetkol(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            index++;
    return index;
}


int size = InputNum("Введите размер массива: ");


int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

int kol = chetkol(myArray);


Console.WriteLine($"Количество четных элементов  равно: {kol}");
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100);
}
string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int sumchet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)
        sum = sum + array[i];
    return sum;
}


int size = InputNum("Введите размер массива: ");


int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

int summ = sumchet(myArray);


Console.WriteLine($"Сумма нечетных элементов массива равна: {summ}");
38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.Next(-100,100) + rnd.NextDouble(), 2); 
}
string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

double Maxel(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max= array[i];
    return max;
}
double Minel(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}
double Diff(double max, double min)
{
    double dif = max - min;
    return dif;
}

int size = InputNum("Введите размер массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

double max1 = Maxel(myArray);
double min1 = Minel(myArray);

Console.WriteLine($"максимальный элемент равен {max1}");
Console.WriteLine($"минимальный элемент {min1}");
double result = Diff(max1, min1);
Console.WriteLine($"Разница между макс и мин элементами =  {result}");
