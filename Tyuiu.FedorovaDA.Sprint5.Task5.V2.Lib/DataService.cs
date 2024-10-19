using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FedorovaDA.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<double> positiveNumbers = new List<double>();

                string line;
                // Чтение файла построчно
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиение строки на части (например, по пробелам, запятым и т.д.)
                    var values = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    // Преобразование значений в double
                    foreach (var value in values)
                    {
                        if (double.TryParse(value, out double number) && number > 0)
                        {
                            positiveNumbers.Add(number);
                        }
                    }
                }
                return positiveNumbers.Average();
                // Если есть положительные числа, возвращаем среднее
                

            }
        }
    }
}
