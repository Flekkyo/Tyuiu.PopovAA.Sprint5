using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PopovAA.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double res = 0;
            string ress;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 2 != 0)
                {
                    res = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2, 2);
                    ress = Convert.ToString(res);
                }
                else
                {
                    ress = "0";
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, ress + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, ress);
                }

            }
            return path;
        }
    }
}
