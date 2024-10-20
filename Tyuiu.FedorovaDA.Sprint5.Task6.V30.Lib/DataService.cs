﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.FedorovaDA.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            // Открываем файл с помощью StreamReader
            using (StreamReader reader = new StreamReader(path))
            {
                string[] words = path.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (words.Length == 8) { count++; }
                }
            }
            return count;
        }
    }
}
