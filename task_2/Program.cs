// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого 
//  числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
 
int a = new Random().Next(100, 999);
Console.WriteLine(a);

int a1 = a / 100;

int a2 = a % 10;

Console.WriteLine($"{a1}{a2}");