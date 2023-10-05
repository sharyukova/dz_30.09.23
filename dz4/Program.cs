using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        static void WriteArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void ChangeInArray(int[] array, int i1, int i2) 
        {
            int c = array[i1];
            array[i1] = array[i2];
            array[i2] = c;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next();
            }
            Console.WriteLine("Массив из 20 рандомных чисел: ");
            WriteArray(array);
            Console.WriteLine("Введите индекс одного элемента (от 0 до 19): ");
            string str1 = Console.ReadLine();
            bool result1 = int.TryParse(str1, out int a);
            Console.WriteLine("Введите индекс другого (от 1 до 19): ");
            string str2 = Console.ReadLine();
            bool result2 = int.TryParse(str2, out int b);
            if (result1)
            {
                if (result2)
                {
                    if (a >= 0 && a < 20)
                    {
                        if (b >= 0 && b < 20)
                        {
                            ChangeInArray(array, a, b);
                            Console.WriteLine("Массив, который мы получили после внесенных изменений:");
                            WriteArray(array);
                        }
                        else
                        {
                            Console.WriteLine("Индекс может быть только натуральным числом и входить в данный диапазон от 0 до 19");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Индекс может быть только натуральным числом и входить в данный диапазон от 0 до 19");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели второе число в неверном формате ");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели первое число в неверном формате");
            }
        }
    }
}
