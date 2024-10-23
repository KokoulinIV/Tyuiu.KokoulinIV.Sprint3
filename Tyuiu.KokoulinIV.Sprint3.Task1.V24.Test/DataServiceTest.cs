using Tyuiu.KokoulinIV.Sprint3.Task1.V24.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSevice ds = new DataSevice();
            int x = 5;
            int y = 1;
            int stop = 12;
            double res = ds.GetSumSeries(x, y, stop);
            double wail = 0.186;
            Assert.AreEqual(wail, res);
        }
    }
}