using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FedorovaDA.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string[] lines = path.Split(' ');
                List<double> values = new List<double>();

                foreach (string line in lines)
                {
                    if (double.TryParse(line, out double number) && number > 0)
                    {
                        values.Add(number);
                    }
                }
                double sum = 0;
                foreach (double value in values)
                {
                    sum += value;
                }

                return Math.Round(sum / values.Count, 3);
            }
        }
    }
}
