using Tyuiu.FedorovaDA.Sprint5.Task4.V14.Lib;
namespace Tyuiu.FedorovaDA.Sprint5.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string Path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
            double res = ds.LoadFromDataFile(Path);
            Console.WriteLine(res);
        }
    }
}
