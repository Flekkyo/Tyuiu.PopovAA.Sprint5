using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PopovAA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            double x = double.Parse(File.ReadAllText(path),CultureInfo.InvariantCulture);
            return Math.Round(Math.Cos(x) + Math.Pow(x, 2) - 2 * x / 1.2, 3);
        }
    }
}
