// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int b = new Random().Next(10, 99);
Console.WriteLine(b);
int a1 = b%10;
int a2 = b/10;
if (a1 > a2) 
{ 
Console.WriteLine(a1);
}
else 
Console.WriteLine(a2);