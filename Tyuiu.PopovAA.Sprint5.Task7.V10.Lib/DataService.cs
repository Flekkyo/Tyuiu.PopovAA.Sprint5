using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PopovAA.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathout = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            string data = File.ReadAllText(path);

            data = data.ToLowerInvariant();

            File.WriteAllText(pathout, data);

            return pathout;
        }
    }
}
