using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                double x = int.Parse(line);
                double res = Math.Round(Math.Sin(Math.Pow(x, 3)) + 2 / x, 3);
                return res;
            }

        }
    }
}
