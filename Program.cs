///Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Ввелите число A - ");
double numberA = double.Parse(Console.ReadLine()!);
Console.Write("Ввелите число B - ");
int numberB = int.Parse(Console.ReadLine()!);
double result_num = numberA;
for (int i = 1; i < numberB; i++)
   {result_num = result_num * numberA; Console.WriteLine(result_num);}
Console.WriteLine(result_num);