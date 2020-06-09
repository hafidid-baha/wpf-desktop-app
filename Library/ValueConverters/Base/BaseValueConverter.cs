using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Library
{
    public abstract class BaseValueConverter<T> : MarkupExtension,IValueConverter
        where T :class,new()
    {
        #region Public Property's
        public T Instance { get; set; } = null;

        #endregion

        #region ValueConverter Methods
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion

        #region Markupr Methods
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance ?? (Instance = new T());
        }

        #endregion
    }
}
