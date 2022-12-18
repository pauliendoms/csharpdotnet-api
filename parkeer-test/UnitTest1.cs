namespace parkeer_test;

using Microsoft.Extensions.DependencyInjection;
using parkeer_api;
using System.Collections;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 500, 345, 2 };
        yield return new object[] { 2, 654, 431, 1 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
    
public class UnitTest1
{
    // test if we get the same object after we just created it with a post request
    [Theory]
    [ClassData(typeof(TestData))]
    public async void TestParkingModel(int i, int cap, int free, int city)
    {
        var parking = new Parking(id: i, capacity: cap, free_spaces: free, city_id: city);

        Assert.Equal(cap, parking.capacity);
    }
}