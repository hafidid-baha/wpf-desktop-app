using System;
using System.Diagnostics;
using System.Globalization;

namespace Library
{
    /// <summary>
    /// <see cref="PagesValueConverter"/> Convert From The <see cref="ApplicationPages"/> Enum To An Object Page
    /// </summary>
    public class PagesValueConverter : BaseValueConverter<PagesValueConverter>
    {
        /// <summary>
        /// Conver from The Pages Enum To The Wanted Page
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>new Page Object</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case ApplicationPages.Index :
                    return new IndexPage();

                case ApplicationPages.Login:
                    return new LoginPage();

                case ApplicationPages.Books:
                    return new BooksPage();

                default:
                    Debugger.Break();
                    break;
            }
            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
