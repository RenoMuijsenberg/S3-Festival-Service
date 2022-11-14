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
                FestivalDay = "Saturday",
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
                FestivalDay = "Saturday",
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
        //Arrange
        var repo = new Mock<IFestivalRepository>();
        repo.Setup(m => m.GetAllFestivals()).ReturnsAsync(_festivals);
        var festivalService = new Services.FestivalService(repo.Object);

        //Act
        var festivals = await festivalService.GetAllFestivals();
        
        //Assert
        Assert.Equal(festivals.Count, _festivals.Count);
    }
    
    [Fact]
    public async void GetSpecificFestival_ReturnsSingleFestival()
    {
        //Arrange
        var repo = new Mock<IFestivalRepository>();
        repo.Setup(m => m.GetSpecificFestival(It.IsAny<string>())).ReturnsAsync(_festivals[0]);
        var festivalService = new Services.FestivalService(repo.Object);

        //Act
        var festival = await festivalService.GetSpecificFestival(It.IsAny<string>());
        
        //Assert
        Assert.Equal(festival, _festivals[0]);
    }
}