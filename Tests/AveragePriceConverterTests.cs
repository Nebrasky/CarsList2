using System.Globalization;
using CarLists;
using CarLists.Converters;
using Microsoft.Maui.Controls;
using Xunit;

namespace CarLists.Tests;

public class AveragePriceConverterTests
{
    [Fact]
    public void Convert_ReturnsAverageForRepositorySettings()
    {
        var converter = new AveragePriceConverter();
        var settings = new RepositorySettings
        {
            MinPrice = 10000,
            MaxPrice = 20000
        };

        var result = converter.Convert(settings, typeof(decimal), null, CultureInfo.InvariantCulture);

        Assert.Equal(15000m, result);
    }

    [Fact]
    public void Convert_ReturnsBindingDoNothing_ForNonRepositorySettings()
    {
        var converter = new AveragePriceConverter();

        var result = converter.Convert("invalid", typeof(decimal), null, CultureInfo.InvariantCulture);

        Assert.Same(Binding.DoNothing, result);
    }

    [Fact]
    public void Convert_ReturnsBindingDoNothing_ForNullValue()
    {
        var converter = new AveragePriceConverter();

        var result = converter.Convert(null, typeof(decimal), null, CultureInfo.InvariantCulture);

        Assert.Same(Binding.DoNothing, result);
    }
}
