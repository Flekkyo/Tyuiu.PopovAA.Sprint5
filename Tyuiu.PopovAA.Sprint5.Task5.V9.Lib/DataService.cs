using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PopovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double max = double.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] array = line.Split(
                        new[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < array.Length; i++)
                    {
                        double value = double.Parse(array[i], CultureInfo.InvariantCulture);
                        if (value % 1 == 0 && value > max)
                        {
                            max = value;
                        }
                    }
                }
            }
            return max;
        }
    }
} 
