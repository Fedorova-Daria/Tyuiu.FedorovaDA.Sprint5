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

            using(StreamReader reader = new StreamReader(path))
            {
                var words = path.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Фильтруем только слова, состоящие из букв и цифр
                return words.Count(word => word.Length == 8);
            }
                
            
        }
    }
}
