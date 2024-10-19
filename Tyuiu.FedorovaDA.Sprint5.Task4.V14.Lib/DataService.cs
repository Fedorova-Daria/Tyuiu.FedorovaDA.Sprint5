using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double res = Math.Round(Math.Sin(Math.Pow(Convert.ToDouble(strx), 3)) + 2 / Convert.ToDouble(strx), 3);
            return res;

        }
    }
}
