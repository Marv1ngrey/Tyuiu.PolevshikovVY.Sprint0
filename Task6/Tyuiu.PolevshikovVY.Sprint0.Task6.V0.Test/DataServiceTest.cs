using Tyuiu.PolevshikovVY.Sprint0.Task6.V0.Lib;

namespace Tyuiu.PolevshikovVY.Sprint0.Task6.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckAddtionArrayValid()
    {
        var nambers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.AdditionArray(nambers);
        Assert.AreEqual(15, res);        
    }

    [TestMethod]
    public void CheckSubtractionArrayValid()
    {
        var nambers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.SubtractionArray(nambers);
        Assert.AreEqual(-15, res);        
    }

    [TestMethod]
    public void CheckMultiplicationArrayValid()
    {
        var nambers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.MultiplicationArray(nambers);
        Assert.AreEqual(120, res);        
    }

}