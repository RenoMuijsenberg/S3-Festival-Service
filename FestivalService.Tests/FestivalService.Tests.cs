using FestivalService.Data.Repositorys;
using FestivalService.Models;
using Xunit;
using Moq;

namespace FestivalService.Tests;

public class FestivalServiceTests
{
    private readonly List<FestivalModel> _festivals;

    public FestivalServiceTests()
    {
        _festivals = new List<FestivalModel>
        {
            new()
            {
                Id = new Guid(),
                FestivalName = "Test",
                FestivalAge = "18",
                FestivalDate = "20-10-2022",
                FestivalDay = "Saterday",
                FestivalLocation = "Test street",
                FestivalOrder = 0,
                FestivalPrice = "20",
                FestivalTimeFrame = "17.00-00.00"
            },
            new()
            {
                Id = new Guid(),
                FestivalName = "Test",
                FestivalAge = "18",
                FestivalDate = "20-10-2022",
                FestivalDay = "Saterday",
                FestivalLocation = "Test street",
                FestivalOrder = 0,
                FestivalPrice = "20",
                FestivalTimeFrame = "17.00-00.00"
            }
        };
    }

    [Fact]
    public async void GetAllFestivals_ReturnsListWithFestivals()
    {
        //Arange
        var repo = new Mock<IFestivalRepository>();
        repo.Setup(m => m.GetAllFestivals()).ReturnsAsync(_festivals);

        var festivalService = new Services.FestivalService(repo.Object);

        //Act
        var festivals = await festivalService.GetAllFestivals();
        
        //Assert
        Assert.Equal(festivals.Count, _festivals.Count);
    }
}