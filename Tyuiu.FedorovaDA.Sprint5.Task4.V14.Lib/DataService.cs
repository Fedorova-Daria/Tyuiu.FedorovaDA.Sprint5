using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double res = Math.Round(Math.Sin(Math.Pow(Convert.ToDouble(x), 3)) + 2 / Convert.ToDouble(x));
            return res;

        }
    }
}
