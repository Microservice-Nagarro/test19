using BHF.MS.test19.Models.Settings;
using FluentAssertions;

namespace BHF.MS.test19.Tests.Models.Settings
{
    public sealed class HealthCheckSettingsTests
    {
        [Fact]
        public void Constructor_DefaultValuesAreSet()
        {
            // Arrange
            var expectedResult = new HealthCheckSettings { AttemptsCount = 1 };

            // Act
            var sut = new HealthCheckSettings();

            // Assert
            sut.Should().BeEquivalentTo(expectedResult);
        }
    }
}

