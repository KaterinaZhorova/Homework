 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 Console.Write("введите число: ");
int a= int.Parse(Console.ReadLine());
 Console.Write("введите число: ");
int b= int.Parse(Console.ReadLine());
 Console.Write("введите число: ");
int c= int.Parse(Console.ReadLine());
int max = a;
if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
 Console.Write("max= ");
 Console.WriteLine(max);
