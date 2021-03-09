using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var masLength = int.Parse(Console.ReadLine());
            int[] mas = new int[masLength];
            for (int i = 0; i < masLength; i++)
            {
                mas[i] = new Random().Next(1, 27);
                Console.WriteLine(mas[i]);
            }
            string[] masOdd = new string[masLength];
            var numberOdd = 0;

            string[] masEven = new string[masLength];
            var numberEven = 0;


            for (int i = 0, iEven = 0, iOdd = 0; i < masLength; i++)
            {
                if ((mas[i] % 2) == 0)
                {
                    IntToMasString(masEven, mas[i], ref iEven);
                }
                else
                {
                    IntToMasString(masOdd, mas[i], ref iOdd);
                }
            }

            Upper(masEven, out numberEven);
            Upper(masOdd, out numberOdd);


            ShowMas(masEven);
            ShowMas(masOdd);

            void IntToMasString(string[] mas, int value, ref int count)
            {
                mas[count] = Convert.ToChar(value + 'a' - 1).ToString();
                count++;
            }

            void Upper(string[] mas, out int numberUpper)
            {
                numberUpper = 0;

                string[] letterUpper = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < letterUpper.Length; j++)
                    {
                        if (mas[i] == letterUpper[j])
                        {
                            mas[i] = mas[i].ToUpper();
                            numberUpper++;
                        }
                    }
                }
            }

            void ShowMas(string[] mas)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + ' ');
                }

                Console.WriteLine();
            }
        }
    }
}
