using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FedorovaDA.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Pow(x - 1, 3 * x + 1);

            
            result = Math.Round(result, 3);

            
            string tempPath = Path.GetTempPath();

            
            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");

            
            string base64;
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(ms))
                {
                    writer.Write(result);
                }
                byte[] bytes = ms.ToArray();
                File.WriteAllBytes(filePath, bytes);
                base64 = Convert.ToBase64String(bytes);
            }

            // Возвращаем результат, Base64 представление и путь к файлу
            return filePath;
        }
    }
}
