using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace SimpleAPI.test;

public class UnitTest1
{
   [Fact]
   public void Test1()
   {

   }

    [Fact]
    public void GetReturnsMyName()
    {
        var _mockLogger = new Mock<ILogger<WeatherForecastController>>();
        WeatherForecastController controller = new WeatherForecastController(_mockLogger.Object);

        var returnValue = controller.Get(1);
        Assert.Equal("Hello Word", returnValue.Value);
    }
}