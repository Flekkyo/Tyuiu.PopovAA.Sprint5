using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PopovAA.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0 && j != matrix.GetLength(1) - 1)
                    {
                        File.AppendAllText(path, "0" + ";");
                    }
                    else if (matrix[i, j] % 2 != 0)
                    {
                        File.AppendAllText(path, "0" + Environment.NewLine);
                    }
                    else if (matrix[i, j] % 2 == 0 && j != matrix.GetLength(1) - 1)
                    {
                        File.AppendAllText(path, Convert.ToString(matrix[i, j]) + ";");
                    }
                    else
                    {
                        File.AppendAllText(path, Convert.ToString(matrix[i, j]) + Environment.NewLine);
                    }
                }
            }
            return path;
        }
    }
} 
