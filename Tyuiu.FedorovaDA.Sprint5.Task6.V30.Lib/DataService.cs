using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.FedorovaDA.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char word in line)
                    {
                        if (char.IsDigit(word))
                        {
                            if (line.Length == 8)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
