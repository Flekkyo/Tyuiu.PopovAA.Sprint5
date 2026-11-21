using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PopovAA.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string new_str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char s in line)
                    {
                        if (char.IsLetter(s))
                        {
                            new_str += s;
                        }

                        else if (s == ' ')
                        {
                            new_str += ' ';
                        }
                    }
                    new_str += ' ';
                }
            }
            string[] words = new_str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Length == 3)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
