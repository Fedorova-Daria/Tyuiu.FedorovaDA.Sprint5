using tyuiu.cources.programming.interfaces.Sprint5;
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

            // Открываем файл с использованием StreamReader
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                // Читаем файл построчно
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на слова по пробелам и другим разделителям
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    // Подсчитываем количество слов длиной 8 символов
                    foreach (var word in words)
                    {
                        if (word.Length == 8)
                        {
                            count++;
                        }
                    }
                }
            }

            return count; // Возвращаем результат
        }
    }
}
