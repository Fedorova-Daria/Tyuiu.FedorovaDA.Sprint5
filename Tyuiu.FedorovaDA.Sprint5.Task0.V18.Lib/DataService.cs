using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FedorovaDA.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = x / Math.Sqrt(Math.Pow(x, 2) + x);
            res = Math.Round(res, 2);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
