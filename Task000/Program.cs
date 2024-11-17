using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task000
{
    // У вас есть переменные x, y и direction которые содержат входные пользовательские данные.
    // x, y содержат числа - стартовая позиция игрока.
    // direction содержит направление движения, одного из: up, down, left, right.
    // Напишите код, который высчитывает новую позицию игрока после перемещения в этом направлении на 1 и записывает результат в переменную result

    internal class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            string direction, result = "";

            string[] inputValues = ReadInput();
            x = int.Parse(inputValues[0]);
            y = int.Parse(inputValues[1]);
            direction = inputValues[2];

            switch (direction)
            {
                case "down":
                    y += 1;
                    break;
                case "left":
                    x -= 1;
                    break;
                case "right":
                    x += 1;
                    break;
                case "up":
                    y -= 1;
                    break;
            }

            result = $"x: {x}, y: {y}, direction: {direction}";
            Console.WriteLine(result);

            //result = direction switch
            //{
            //    "up" => $"x: {x}, y: {y - 1}, direction: {direction}",
            //    "down" => $"x: {x}, y: {y + 1}, direction: {direction}",
            //    "left" => $"x: {x - 1}, y: {y}, direction: {direction}",
            //    "right" => $"x: {x + 1}, y: {y}, direction: {direction}"
            //};
        }

        public static string[] ReadInput()
        {
            string[] inputValues = new string[3];

            if (Console.ReadLine() is string input)
            {
                string[] values = input.Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    inputValues[i] = values[i];
                }
            }

            return inputValues;
        }
    }
}
