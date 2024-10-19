using System.IO;
using Tyuiu.FedorovaDA.Sprint5.Task6.V30.Lib;
namespace Tyuiu.FedorovaDA.Sprint5.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V30.txt                      *");
            Console.WriteLine("* в котором есть набор символьных данных.                                 *");
            Console.WriteLine("* Найти количество слов длиной восемь символов в заданной строке.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path;
            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
        }
    }
}
