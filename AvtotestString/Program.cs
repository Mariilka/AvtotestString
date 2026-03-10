//Дано предложение. Ограничить долю (в %) буквой нем.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("\nВведите предложение (или 'exit' для выхода):");
                string sentence = Console.ReadLine();

                if (sentence?.ToLower() == "exit")
                    break;

                // Используем метод из класса Logic
                double letterPercentage = Logic.CalculateLetterPercentage(sentence);

                Console.WriteLine($"Предложение: \"{sentence}\"");
                Console.WriteLine($"Доля букв: {letterPercentage:F2}%");
            }



        }
    }
    public  class Logic
    {
        public static double CalculateLetterPercentage(string text)
        {
            if (string.IsNullOrEmpty(text)) // является ли строка пустой
                return 0;

            int letterCount = text.Count(char.IsLetter);// считает кол-во элементов
            int totalChars = text.Length;

            return (double)letterCount / totalChars * 100;
        }
    }

}
