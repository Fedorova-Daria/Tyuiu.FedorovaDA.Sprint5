using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FedorovaDA.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            double calculatedResult = Math.Pow(x - 1, 3 * x + 1);

            // Округление до целого числа
            int intResult = (int)Math.Round(calculatedResult);

            // Получение пути к временной директории
            string tempPath = Path.GetTempPath();

            // Формирование полного пути к файлу
            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");

            // Запись результата в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(intResult);
            }

            // Чтение файла и конвертация в Base64
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string base64String = Convert.ToBase64String(fileBytes);

            // Возвращаем кортеж с результатом, путем к файлу и Base64 представлением
            return filePath;
        }
    }
}
