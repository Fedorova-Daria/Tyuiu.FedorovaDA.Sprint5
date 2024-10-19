using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.FedorovaDA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V12.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c >= 'а' && c <= 'я')
                        {
                            result.Append((char)(c - 32));
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}
