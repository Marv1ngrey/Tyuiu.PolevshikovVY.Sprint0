using Tyuiu.PolevshikovVY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PolevshikovVY.Sprint0.Task2.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Василий";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Василий", res);
    }
}