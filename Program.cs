//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("введите первое число: ");
int a= int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int b= int.Parse(Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"большее число {a} меньшее число {b}");
}else
{
    Console.WriteLine($"меньшее число {a} большее число {b}");
}
