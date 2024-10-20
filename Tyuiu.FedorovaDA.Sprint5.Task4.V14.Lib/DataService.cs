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
            double result = 0;

            // Чтение данных из файла с использованием StreamReader
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line = reader.ReadLine();
                double x = double.Parse(line);

                
                result = Math.Sin(Math.Pow(x, 3)) + 2 / x;

                
                result = Math.Round(result, 3);
            }

            return result;
        }
    }
}
