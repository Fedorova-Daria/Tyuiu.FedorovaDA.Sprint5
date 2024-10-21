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
            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd();
            }

            
            if (!double.TryParse(content, out double x))
            {
                throw new FormatException("Неверный формат числа в файле.");
            }

            // Вычисление значения по формуле
            double y = Math.Sin(Math.Pow(x, 3)) + (2 / x);

            
            return Math.Round(y, 3);
        }
    }
}
