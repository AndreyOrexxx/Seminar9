// Задача 64 
 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от М до N. 
 
// M = 5; N = 1. -> " 5, 4, 3, 2, 1 " 
// M = 8; N = 4. -> " 8, 7, 6, 5, 4 " 
 
int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
int count = n + 2; 
 
PrintNumber(m, count); 
Console.Write($"{n + 1}, "); 
Console.Write(n); 
 
void PrintNumber(int m, int count) 
{ 
    if (count > m) return; 
    PrintNumber(m, count + 1); 
    Console.Write(count + ", "); 
} 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
}