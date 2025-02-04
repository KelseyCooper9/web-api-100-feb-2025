namespace SoftwareCatalog.Tests;

public class UnitTest1
{
    [Fact]
    public void CanAddTenAndTwentyInDotNet()
    {
        // "Given"
        int a = 10, b = 20, answer;

        // When
        answer = a + b; // System Under Test (SUT)

        // Then 
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 3, 5)]
    [InlineData(10, 2, 12)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        var answer = a + b;

        Assert.Equal(expected, answer);
    }
    [Fact]
    public void DoingThingsWithACustomer()
    {
        var cust = new Customer()
        {
            Name = "Bob",
            CreditLimit = 5000,
            Id = 42
        };

        var cust2 = new Customer()
        {
            Name = "Bob",
            CreditLimit = 5000,
            Id = 42
        };

        Assert.Equal(cust, cust2);

        var cust3 = cust with { Name = "Robert" };
    }
}
public record Customer
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal CreditLimit { get; set; }
    public string EmailAddrses { get; set; } = string.Empty;
}

