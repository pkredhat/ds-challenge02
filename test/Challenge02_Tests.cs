using ds_challenge02.Controllers;

namespace Challenge2Tests;

public class Challenge02_Tests
{
     [Fact]
        public async Task Get_CalculateAndPrintStatistics()
        {
            // Arrange
            var controller = new CalculateAndPrintStatisticsController();

            // Act
            var result = controller.calculateandprintstatistics([10,20,30]);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.ToString(), "Average: 20 | Maximum: 30 | Minimum: 10");
        }


        public async Task Get_CurrentDate()
        {
            // Arrange
            var controller = new DateController();

            // Act
            //TODO WRITE a result object
           
            // Assert
            //TODO WRITE TESTS

        }
}