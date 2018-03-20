using MvvmCross.Platform.Converters;

namespace MvvmCrossValueConverters.ValueConverters
{
    public class BoolNegationValueConverter : MvxValueConverter<bool, bool>
    {
        protected override bool Convert(bool value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !value;
        }

        protected override bool ConvertBack(bool value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !value;
        }
    }
}