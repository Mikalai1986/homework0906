/*Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);
int temp = num;
int fin = num;
int count = 0;
while (temp != 0)
{
    temp = temp/10;
    count++;
}
int[] array = new int[count];
for (int i = count-1; i >= 0; i--)
{
    array[i] = num % 10;
    num = num / 10;
}int srav = 0;
for ( int  i = 0; i <= (count -1)/2; i++)
if (array[i] == array[count-1-i])
Console.Write("");
else
srav++;
if (srav>0)
    Console.WriteLine($"Число {fin} - не палиндром");
else
    Console.WriteLine($"Число {fin} - палиндром");

Напишите программу, которая на вход принимает координаты двух точек и находит между ними расстояние в 3d пространстве
*/
int InputNum(string message) 
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double Quart(int xa, int ya, int za, int xb, int yb, int zb)
{
   double sq = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2)); 
   return sq;
}
int xa = InputNum("введите Х точки А:");
int ya = InputNum("введите Y точки А:");
int za = InputNum("введите Z точки А:");

int xb = InputNum("введите Х точки В:");
int yb = InputNum("введите Y точки В:");
int zb = InputNum("введите Z точки B:");

double res = Quart(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Растояние между точками = {res}");