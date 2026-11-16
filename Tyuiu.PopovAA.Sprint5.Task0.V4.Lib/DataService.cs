using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;  
namespace Tyuiu.PopovAA.Sprint5.Task0.V4.Lib
{
    public class DataService : ISprint5Task0V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double res = 2 * Math.Pow(x, 3) + 1.0 / 2.0 * Math.Pow(x, 2) - 3.5 * x + 2;
            res = Math.Round(res, 3);

            File.WriteAllText(path, Convert.ToString(res));

            return path;
        }
    }
}
