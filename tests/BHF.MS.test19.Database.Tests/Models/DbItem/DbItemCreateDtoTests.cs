using BHF.MS.test19.Database.Models.DbItem;
using FluentAssertions;

namespace BHF.MS.test19.Database.Tests.Models.DbItem
{
    public sealed class DbItemCreateDtoTests
    {
        [Fact]
        public void Constructor_DbItem_ShouldCopyValues()
        {
            // Arrange
            var dbItem = new Context.Entities.DbItem { Name = "abc" };
            var expectedResult = new DbItemCreateDto { Name = dbItem.Name };

            // Act
            var sut = new DbItemCreateDto(dbItem);

            // Assert
            sut.Should().BeEquivalentTo(expectedResult);
        }
    }
}

