using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    //У вас есть переменные x, y и direction которые содержат входные пользовательские данные.
    //Игровое поле размера от 0 до 100 по x и от 0 до 100 по y.
    //x, y содержат числа - стартовая позиция игрока.
    //direction содержит направление движения, одного из: up, down, left, right.
    //Напишите код, который высчитывает новую позицию игрока после перемещения в этом направлении на 1 и записывает результат в переменную result.
    //Учитывайте то, что новая позиция игрока не должна быть меньше 0 или больше 100 как x так и по y.
    //Например, если новая позиция игрока больше 100 тогда, устанавливаем ему значение 100, 
    //а если новая позиция игрока меньше 0 тогда устанавливаем ему значение 0 по x или по y в зависимости от того какую границу игрок перешел.

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

            if (x >= 100) x = 100;
            if (y >= 100) y = 100;
            if (x <= 0) x = 0;
            if (y <= 0) y = 0;

            result = $"x: {x}, y: {y}, direction: {direction}";
            Console.WriteLine(result);
          
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
