using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
    //У вас есть переменная n, которая содержит входные пользовательские данные.
    //Напишите код, который проверяет является ли значение n негативным, позитивным или равно 0 и записывает результат в переменную result.
    //Если n позитивное число тогда result = "Число позитивное"
    //Если n негативное число тогда result = "Число негативное"
    //Если n равно 0 число тогда result = "Число равно 0"

    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = ReadInput();
            string result = "";            

            if (n == 0) result = "Число равно 0";
            else  result = n > 0 ? "Число позитивное" : "Число негативное";


            Console.WriteLine(result);
        }

        public static int ReadInput()
        {
            string inputLine = Console.ReadLine();
            return int.Parse(inputLine);
        }
    }
}
