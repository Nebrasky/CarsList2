using System.Globalization;
using CarLists;
using Microsoft.Maui.Controls;

namespace CarLists.Converters
{
    public class AveragePriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is RepositorySettings repository)
            {
                return repository.MinPrice + repository.MaxPrice / 2m;
            }

            return 0m;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
