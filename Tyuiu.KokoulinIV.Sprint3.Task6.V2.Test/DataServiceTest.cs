using Tyuiu.KokoulinIV.Sprint3.Task6.V2.Lib;
namespace Tyuiu.KokoulinIV.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 12;
            int b = 18;
            int wail = 29;
            int res = ds.GetSumTheDivisors(a, b);
            Assert.AreEqual(wail, res);

        }
    }
}