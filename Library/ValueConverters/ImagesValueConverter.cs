using System;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Library
{
    /// <summary>
    /// Convert The Image String Path to An Actual Image Object
    /// </summary>
    public class ImagesValueConverter : BaseValueConverter<ImagesValueConverter>
    {
        /// <summary>
        /// Convert from the string path to an actual image
        /// </summary>
        /// <param name="value">The Image Path</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>new Object Page</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string name = (string)value;
            try
            {
                return new BitmapImage(new Uri($"pack://application:,,,/Images/{(string)value}"));
            }catch(Exception ex)
            {
                return new BitmapImage(new Uri($"pack://application:,,,/Images/admin.png"));
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
