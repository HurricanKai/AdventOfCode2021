using Implementation;
using Xunit;

namespace Tests;

public class Tests
{
    [Fact]
    public void Day1Part1()
    {
        Assert.Equal(7, Day1.Part1(@"199
200
208
210
200
207
240
269
260
263"));
    }
    [Fact]
    public void Day1Part2()
    {
        Assert.Equal(5, Day1.Part2(@"199
200
208
210
200
207
240
269
260
263"));
    }
}
