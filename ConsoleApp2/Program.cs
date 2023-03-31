using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions with an array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity, begin, end, sum = 0, multiply = 0, beginN, endK, sum2 = 0, beginAverage, endAverage, sumAverage = 0, sum3 = 0;
            double sumSquares = 0, sumSquares2 = 0, arithmeticMean, arithmeticMean2;
            Console.Write("Здравствуйте, введите кол-во элементов: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Начало интервала: ");
            begin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец интервала: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Начало интервала для суммы чисел: ");
            beginN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец интервала для суммы чисел: ");
            endK = Convert.ToInt32(Console.ReadLine());
            Console.Write("Начало интервала для ср. арифмитического: ");
            beginAverage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец интервала для ср. арифмитического: ");
            endAverage = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[quantity];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(begin, end + 1);
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    break;
                }
                multiply += array[i] * array[i + 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sumSquares += Math.Pow(array[i], 2);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 6)
                {
                    break;
                }
                sumSquares2 += array[i];
            }

            for (; beginN - 1 < endK; beginN++)
            {
                sum2 += array[beginN - 1];
            }

            arithmeticMean = Math.Round(Convert.ToDouble(array.Length) / sum, 3);

            for (; beginAverage - 1 < endAverage; beginAverage++)
            {
                sumAverage += array[beginAverage - 1];
                sum3++;
            }
            arithmeticMean2 = Math.Round(Convert.ToDouble(sum3) / sumAverage, 3);

            Console.WriteLine("Результаты вычислений:");
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[");
                Console.Write(array[i]);
                Console.Write("] ");
            }
            Console.WriteLine($"\n1) Сумма всех элементов: {sum}");
            Console.WriteLine($"2) Произведение всех элементов: {multiply}");
            Console.WriteLine($"3) Сумма квадратов всех элементов: {sumSquares}");
            Console.WriteLine($"4) Сумма 6ти первых элементов: {sumSquares2}");
            Console.WriteLine($"5) Сумма элементов в интервале [{endK},{beginN}] : {sum2}");
            Console.WriteLine($"5) Ср. арифмитическое всех элемнтов: {arithmeticMean}");
            Console.WriteLine($"6) Ср. арифмитическое элементов в интервале [{beginAverage},{endAverage}] : {arithmeticMean2}");
        }
    }
}
