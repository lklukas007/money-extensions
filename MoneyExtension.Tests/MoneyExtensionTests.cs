namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98M;
        var cents = value.ToCents();

        Assert.AreEqual(expected: 27998, cents);
    }
}