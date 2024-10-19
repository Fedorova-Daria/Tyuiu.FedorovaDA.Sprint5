using Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path;

            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
