using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FedorovaDA.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(path); }

            double res;
            string strRes;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                strRes = Convert.ToString(res);

                if (Math.Sin(x) - 3 + x == 0)
                {
                    File.AppendAllText(path, "0");
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }
            return path;
        }
    }
}
