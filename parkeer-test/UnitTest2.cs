namespace parkeer_test;

using parkeer_api;
using System.Collections;

public class TestData2 : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, "Leuven" };
        yield return new object[] { 2, "Mechelen" };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class UnitTest2
{
    [Theory]
    [ClassData(typeof(TestData2))]
    public async void TestStadModel(int i, string n)
    {
        var stad = new Stad();
        stad._id = i;
        stad.name = n;

        Assert.Equal(n, stad.name);
    }
}