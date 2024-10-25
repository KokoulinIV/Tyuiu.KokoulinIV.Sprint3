using Tyuiu.KokoulinIV.Sprint3.Task3.V27.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string  a = "gfd98fds";
            int b = 98;
            int result = ds.ConvertStringToInt(a);
            Assert.AreEqual(b, result);

        }
    }
}