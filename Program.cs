//  Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

// void BinarySystem(int numb)
// {
//     if(numb < 0)
//         numb *= -1;
//     if(numb != 1 && numb != 0) BinarySystem(numb / 2);
//         Console.Write(numb % 2);
// }
// Console.Write("Введите число: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ваше число в двоичной системе исчисления: ");
// BinarySystem(numb);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// int SumNumbersBetweenMN(int m, int n)
// {
//     if (m == n) return m;
//     else if (m < n) return n + SumNumbersBetweenMN(m, n - 1);
//     else return n + SumNumbersBetweenMN(m, n + 1);
// }
// Console.Write("Введите число M = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Ваша сумма элементов между M и N = {SumNumbersBetweenMN(m, n)}");
 