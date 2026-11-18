using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PopovAA.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string res = Convert.ToString(Math.Round(x * Math.Pow(x + 3, 0.5), 3));
            return res;
        }
    }
}
