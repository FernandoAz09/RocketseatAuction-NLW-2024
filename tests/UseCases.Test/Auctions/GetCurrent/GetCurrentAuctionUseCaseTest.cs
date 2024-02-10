using FluentAssertions;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Success()
    {
        //Arrange
        var useCase = new GetCurrentAuctionUseCase(null);

        //Act
        var auction = useCase.Execute();

        //Assert
        //Assert.NotNull(auction);

        auction.Should().NotBeNull();
    }
}
