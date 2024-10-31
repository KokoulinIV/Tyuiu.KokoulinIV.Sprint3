using Tyuiu.KokoulinIV.Sprint3.Task7.V12.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task7.V12
{
    internal class Program
    {
        private const string Format = "|{0,5:d}       |  {1,6:f2}   |";

        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [12, 18] количество всех делителей      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Start = -5");
            Console.WriteLine(" Stop = 5");

            int start = -5;
            int stop = 5;
            int ltn = ds.GetMassFunction(start, stop).Length;
            double[] valueArray= new double[ltn];
            valueArray = ds.GetMassFunction(start, stop);

            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("|      X     |    F(x)   |");
            Console.WriteLine("+------------+-----------+");
            for (int i = 0; i<=ltn-1; i++)
            {
                Console.WriteLine(Format, +start, valueArray[i]);
            }
            Console.WriteLine("+------------+-----------+");
            Console.ReadKey();
        }
    }
}
