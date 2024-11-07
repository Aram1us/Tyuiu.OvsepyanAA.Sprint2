using Tyuiu.OvsepyanAA.Sprint2.Task3.V21.Lib;

namespace Tyuiu.OvsepyanAA.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(242, ds.Calculate(2));
        }
    }
}