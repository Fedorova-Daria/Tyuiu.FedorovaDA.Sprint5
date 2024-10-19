using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FedorovaDA.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            double res = Math.Round(Math.Pow(x -1, 3*x+1), 3);

            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }

            return path;
        }
    }
}
