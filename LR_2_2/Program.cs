using System;

namespace LR_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ИНН");
            string inn;
            inn = Console.ReadLine();
            var innValidation = new INNValidator();
            if (inn.Length == 10)
            {
                int[] innForValid = new int [10];
                for (int i = 0; i < inn.Length; i++)
                {
                    innForValid[i] = Int32.Parse(inn[i].ToString());
                }
                Console.WriteLine(innValidation.check10DigitInn(innForValid));
            }
            if (inn.Length == 12)
            {
                int[] innForValid = new int[12];
                for (int i = 0; i < inn.Length; i++)
                {
                    innForValid[i] = Int32.Parse(inn[i].ToString());
                }
                Console.WriteLine(innValidation.check12DigitInn(innForValid));
            }
            Console.ReadLine();
        }
    }
}
