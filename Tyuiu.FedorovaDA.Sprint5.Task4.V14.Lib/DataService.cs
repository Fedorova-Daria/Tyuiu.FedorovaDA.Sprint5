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
            
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }
            double res = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string content = reader.ReadLine();
                    
                    res = Math.Round(Math.Sin(Math.Pow(Convert.ToDouble(line), 3)) + (2 / Convert.ToDouble(line)), 3);
                }
            }
            return res;
        }
    }
}
