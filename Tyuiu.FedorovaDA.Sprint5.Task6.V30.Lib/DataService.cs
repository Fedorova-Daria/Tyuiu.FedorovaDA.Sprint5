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
            

            using(StreamReader reader = new StreamReader(path))
            {
                

                string[] words = path.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;

                foreach (string word in words)
                {
                    if (word.Length == 8)
                    {
                        count++;
                    }
                }
                return count;
            }
            
        }
    }
}
