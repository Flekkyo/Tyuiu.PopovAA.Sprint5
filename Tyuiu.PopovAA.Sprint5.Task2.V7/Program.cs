using Tyuiu.PopovAA.Sprint5.Task2.V7.Lib;
namespace Tyuiu.PopovAA.Sprint5.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись структурированных данных в текстовый файл            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк: ");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int stl = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[str, stl];

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stl; j++)
                {
                    Console.Write($"Введите элемент с индексом [{i}, {j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Получившаяся матрица: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j != array.GetLength(1) - 1)
                    {
                        Console.Write("|" + array[i, j] + "; ");
                    }
                    else
                    {
                        Console.WriteLine(array[i, j] + "|");
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(array);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
        }
    }
} 
