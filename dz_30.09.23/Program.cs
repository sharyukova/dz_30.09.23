using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dz_30._09._23
{
    internal class Program
    {
        // 5.1
        static int Maxim(int a, int b)
        {
            if (a >= b)
            {
                int mmaxi = a;
                return mmaxi;
            }
            else 
            {
                int mmaxi = b;
                return mmaxi;
            }
            
        }
        // 5.2
        static void Change(ref int aa, ref int bb)
        {
            
            int c = aa;
            aa = bb;
            bb = c;
            Console.WriteLine(aa + " " + bb);
        }
        // 5.3
        public static bool Factorial(int number, out int result)
        {
            result = 1;

            try
            {
                checked
                {
                    for (int i = 2; i <= number; i++)
                    {
                        result *= i;
                    }
                }

                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        // 5.4
        static int FactorialRecursive(int num)
        {
            if (num == 1) 
                return 1;
            else
                return num * FactorialRecursive(num - 1); 
        }
        // домашнее задание 5.1
        static int Evclid(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            return n;
        }
        static int Evclid(int a, int b, int c)
        {
            return Evclid(Evclid(a, b), c);
        }
        // домашнее задание 5.2
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            // 5.1
            Console.WriteLine("Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные\r\nпараметры метода – два целых числа. Протестировать метод.");
            Console.WriteLine("Введите первое целое число: ");
            string str1 = Console.ReadLine();
            bool result1 = int.TryParse(str1, out int a);   
            Console.WriteLine("Введите второе целое число: ");
            string str2 = Console.ReadLine();
            bool result2 = int.TryParse(str2, out int b);
            if (result1) 
            {
                if (result2) 
                {
                    int maxi = Maxim(a, b);
                    Console.WriteLine("Максимальным числом является " + maxi);
                }
                else 
                { 
                    Console.WriteLine("Вы неправильно ввели второе число");
                }
            }
            else 
            {
                Console.WriteLine("Вы неправильно ввели первое число");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            // 5.2
            Console.WriteLine("Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых\r\nпараметров. Параметры передавать по ссылке. Протестировать метод.");
            Console.WriteLine("Введите первое целое число: ");
            string str11 = Console.ReadLine();
            bool result11 = int.TryParse(str11, out int aa);
            Console.WriteLine("Введите второе целое число: ");
            string str22 = Console.ReadLine();
            bool result22 = int.TryParse(str22, out int bb);
            if (result11)
            {
                if (result22)
                {
                    Console.WriteLine(aa + " " + bb);
                    Change(ref aa, ref bb);
                }
                else
                {
                    Console.WriteLine("Вы неправильно ввели второе число");
                }
            }
            else
            {
                Console.WriteLine("Вы неправильно ввели первое число");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            // 5.3 
            Console.WriteLine("Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений\r\nпередавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;\r\nесли в процессе вычисления возникло переполнение, то вернуть значение false. Для\r\nотслеживания переполнения значения использовать блок checked.");
            Console.WriteLine("Введите целое положительное число: ");
            string str1_ = Console.ReadLine();
            bool result1_ = int.TryParse(str1_, out int a_);
            if (result1_)
            {
                if (a_ >= 0)
                {
                    bool success = Factorial(a_, out int resultat);
                    if (success)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("Введенное число меньше нуля");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат числа");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            // 5.4
            Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.\r\n");
            Console.WriteLine("Введите натуральное число: ");
            string str1__ = Console.ReadLine();
            bool result1__ = int.TryParse(str1__, out int a__);
            if (result1__)
            {
                if (a__ >= 0)
                {
                    int resultat_ = FactorialRecursive(a__);
                    Console.WriteLine($"Факториалом числа {a__} является {resultat_}");
                }
                else
                {
                    Console.WriteLine("Введенное число меньше нуля");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат числа");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            // домашнее задание 5.1
            Console.WriteLine("Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел\r\n(алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех\r\nнатуральных чисел.");
            Console.WriteLine("Введите первое натуральное число: ");
            string str51 = Console.ReadLine();
            bool result51 = int.TryParse(str51, out int a51);
            Console.WriteLine("Введите второе натуральное число: ");
            string str15 = Console.ReadLine();
            bool result15 = int.TryParse(str15, out int b51);
            if (result51)
            {
                if (result15)
                {
                    if (a51 > 0) 
                    {
                        if (b51 > 0)
                        {
                            int nod = Evclid(a51, b51);
                            Console.WriteLine($"НОД {a51} и {b51} равен {nod}");
                        }
                        else
                        {
                            Console.WriteLine("Введенное второе число не натуральное");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Введенное первое число не натуральное");
                    }
                }
                else
                {
                    Console.WriteLine("Вы неправильно ввели второе число");
                }
            }
            else
            {
                Console.WriteLine("Вы неправильно ввели первое число");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Введите первое натуральное число: ");
            string str51_ = Console.ReadLine();
            bool result51_ = int.TryParse(str51_, out int a51_);
            Console.WriteLine("Введите второе натуральное число: ");
            string str15_ = Console.ReadLine();
            bool result15_ = int.TryParse(str15_, out int b51_);
            Console.WriteLine("Введите второе натуральное число: ");
            string str3_ = Console.ReadLine();
            bool result3_ = int.TryParse(str3_, out int c51);
            if (result51_)
            {
                if (result15_)
                {
                    if (result3_)
                    {
                        if (a51_ > 0)
                        {
                            if (b51_ > 0)
                            {
                                if (c51 > 0)
                                {
                                    int nod1 = Evclid(a51_, b51_, c51);
                                    Console.WriteLine($"НОД {a51_}, {b51_} и {c51} равен {nod1}");
                                }
                                else
                                {
                                    Console.WriteLine("Введенное третье число не натуральное");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введенное второе число не натуральное");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введенное первое число не натуральное");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы неправильно ввели третье число");
                    }
                }
                else
                {
                    Console.WriteLine("Вы неправильно ввели второе число");
                }
            }
            else 
            {
                Console.WriteLine("Вы неправильно ввели первое число");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------\n");
            // домашнее задание 5.2
            Console.WriteLine("Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа\r\nряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,\r\n13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .\r\n");
            Console.WriteLine("Введите натуральное число: ");
            string str52 = Console.ReadLine();
            bool result52 = int.TryParse(str52, out int a52);
            if (result52)
            {
                if (a52 > 0)
                {
                    int resultFib = Fibonacci(a52);
                    Console.WriteLine($"Значение {a52}-ого(его) элемента ряда Фибоначчи является {resultFib}");
                }
                else
                {
                    Console.WriteLine("Введенное число меньше нуля");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат числа");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
}
