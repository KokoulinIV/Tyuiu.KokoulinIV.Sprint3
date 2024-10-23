using Tyuiu.KokoulinIV.Sprint3.Task1.V24.lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSrvice ds = new DataSrvice();
            int x = 5;
            int y = 1;
            int stop = 12;
            double res = ds.GetSumSeries(x, y, stop);
            double wail = 0.186;
            Assert.AreEqual(wail, res);
        }
    }
}