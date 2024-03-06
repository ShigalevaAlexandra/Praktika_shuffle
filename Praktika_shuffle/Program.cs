using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title_programm = @"
    
    ▒█▀▀▀█ ▒█░▒█ ▒█░▒█ ▒█▀▀▀ ▒█▀▀▀ ▒█░░░ ▒█▀▀▀ 
    ░▀▀▀▄▄ ▒█▀▀█ ▒█░▒█ ▒█▀▀▀ ▒█▀▀▀ ▒█░░░ ▒█▀▀▀ 
    ▒█▄▄▄█ ▒█░▒█ ░▀▄▄▀ ▒█░░░ ▒█░░░ ▒█▄▄█ ▒█▄▄▄";


            Console.WriteLine(title_programm);

            Console.SetCursorPosition(0, 6);

            Console.WriteLine(
                "\r\n    1. Enter - использовать функцию Shuffle() \r\n" +
                "    2. Esc - завершение программы \r\n");

            Console.SetCursorPosition(0, 10);
            Console.WriteLine(new string('_', Console.WindowWidth));  //рисование линии во всю ширину рабочего окна
            /*------------------------------------------------------------------------------------------------------*/

            Console.SetCursorPosition(0, 13);

            Console.WriteLine("\r\n    >> Введите кол-во элементов массива: \r\n");
            Console.SetCursorPosition(4, 15);
            int mas_size = int.Parse(Console.ReadLine());  //размер массива

            int[] mas = new int[mas_size];   //массив
            Random random = new Random();

            Console.WriteLine("\r\n    >> Исходный массив: \r\n");
            Create_mas(mas, random);
            Console.SetCursorPosition(4, 19);
            Print_mas(mas);

            //выбор команды
            ConsoleKey user_command = Console.ReadKey().Key;

            switch (user_command)
            {
                case ConsoleKey.Enter:
                    Shuffle(mas, random);
                    Console.WriteLine("\r\n    >> Новый массив: \r\n");
                    Console.SetCursorPosition(4, 23);
                    Print_mas(mas);
                    Console.WriteLine("\r\n\r\n");
                    break;

                case ConsoleKey.Escape: 
                    break;

            }
        }

        //Функция для создания масссива из случайных чисел
        static void Create_mas(int[] mas, Random random)
        {
            for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(100);
        }

        //Функция вывода полученного массива
        static void Print_mas(int[] mas)
        {
            foreach (int i in mas) Console.Write(i + " ");
            Console.WriteLine();
        }

        //Функция перемешивания элементов массива
        static void Shuffle(int[] mas, Random random)
        {
            for (int i = mas.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int item  = mas[i];
                mas[i] = mas[j];
                mas[j] = item;
            }
        }
    }
}