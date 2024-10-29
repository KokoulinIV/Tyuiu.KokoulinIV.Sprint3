using Tyuiu.KokoulinIV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int a1 = 1;
            int b1 = 1;
            int a2 = 3;
            int b2 = 10;
            double res = ds.GetSumSumSeries(x, a1, b1, a2, b2);
            double wail = 25.981;
            Assert.AreEqual(wail, res);
        }
    }
}