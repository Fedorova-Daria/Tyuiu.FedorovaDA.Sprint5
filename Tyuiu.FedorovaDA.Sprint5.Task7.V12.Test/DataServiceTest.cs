using Tyuiu.FedorovaDA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.FedorovaDA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V12.txt" });
            var res = ds.LoadDataAndSave(path);
            Assert.AreEqual(Path.Combine(new string[] { "C:", "DataSprint5", "OutPutDataFileTask7V12.txt" }), res);
        }
    }
}