﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine(" Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
 
SumFromMToN(M, N); 

void SumFromMToN(int m, int n) 
{ 
Console.Write(SumMN(m - 1, n)); 
} 
int SumMN(int m, int n) 
{ 
int res = m; 
if (m == n) 
return 0; 
else 
{ 
m++; 
res = m + SumMN(m, n); 
return res;}
}