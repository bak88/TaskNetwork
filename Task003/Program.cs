using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task003
{
    //У вас есть переменные n, m, k, которые содержат входные пользовательские данные.
    //Волшебник продает волшебные мечи принцам, желающим убить дракона.
    //У каждого меча есть основная характеристика – число драконьих голов, которые он срубает за один удар.Драконы имеют свои характеристики, включая число голов и скорость регенерации голов.
    //Число n, представляющее число голов, которые меч срубает одним ударом.
    //Число m, представляющее число голов дракона.
    //Число k, представляющее число голов, которые дракон может отрастить за раз.
    //Напишите код, который определяет, сможет ли принц убить дракона, используя определенный меч, и если да, то сколько ударов потребуется. 
    //При этом, бои принцев с драконами всегда протекают одинаково: принц атакует дракона, а затем прячется за щитом; дракон атакует огненным дыханием и может восстановить потерянные головы.
    //Если принц может убить дракона, ваше решение должно записать в переменную result количество ударов, необходимых для убийства дракона.
    //Если убить дракона таким мечом невозможно, ваше решение должно записать в переменную result значение -1.

    internal class Program
    {
        public static void Main(string[] args)
        {
            Tuple<int, int, int> triple = ReadInput();
            int n = triple.Item1;
            int m = triple.Item2;
            int k = triple.Item3;
            int result = 0;


            // 4 4 5 = 1
            // 4 - 4 + 5 = 1

            // 5 10 6
            // 10 - 5 + 6 = 11




            if (n == m)
            {
                result = 1;
                Console.WriteLine(result);
                return;
            }

            result = m - n + k;

            if (result > m)
            {
                result = -1;
                Console.WriteLine(result);
                return;
            }
            else
            {
                // 3 6 2 == 4
                // 6 - 3 + 2 = 5
                // 5 - 3 + 2 = 4
                // 4 - 3 + 2 = 3
                // 3 - 3 + 2 = 2

                // 4 10 1
                // 10 - 4 + 1 = 7
                // 7 - 4 + 1 = 4
                // 4 - 4 + 1 =1

                int i = 1;
                for (; i < result; i++)
                {
                    m = result;
                    result = m - n + k;

                    if (n <= result - 1)
                    {
                        
                        i++;
                    }
                   
                }
                result = i;
            }

            Console.WriteLine(result);
        }

        public static Tuple<int, int, int> ReadInput()
        {
            string input = Console.ReadLine();
            string[] inputs = input.Trim().Split(' ', '|', ' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int k = int.Parse(inputs[2]);
            return Tuple.Create(n, m, k);
        }
    }
}
