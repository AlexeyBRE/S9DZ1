// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
int M=1;
void Natural(int N, int M)
{
    
    if (M!=N)
    {
     Natural(N,M+1);
      Console.Write(M);
    }
    else if(M==N)
    {
        Console.Write(M);
    }
}
Natural(N,M);