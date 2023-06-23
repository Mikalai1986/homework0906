/*Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве
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
