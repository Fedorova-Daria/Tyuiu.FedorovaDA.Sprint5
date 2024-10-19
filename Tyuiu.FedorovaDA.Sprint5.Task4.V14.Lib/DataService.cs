using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {


            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadLine();
                double.TryParse(content, out double x);
                double res = Math.Round(Math.Sin(Math.Pow(x, 3)) + (2 / x), 3);
                return res;
                
            }

        }
    }
}
