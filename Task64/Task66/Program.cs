// Задача 66 
 
// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от М до N. 
 
// M = 1; N = 15 -> 120 
// M = 4; N = 8 -> 30 
 
int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
int temp = m; 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
} 
 
if (m > n) 
{ 
    m = n; 
    n = temp; 
} 
 
void PrintSumm(int m, int n, int summ) 
{ 
    summ = summ + n; 
    if (n <= m) 
    { 
        Console.Write($"Сумма элементов = {summ} "); 
        return; 
    } 
    PrintSumm(m, n - 1, summ); 
} 
 
PrintSumm(m, n, temp=0);