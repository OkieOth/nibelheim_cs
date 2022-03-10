using Xunit;

namespace nibelheim.types.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 class1 = new Class1();
        class1.Hello();
        Assert.Null(class1);
    }
}