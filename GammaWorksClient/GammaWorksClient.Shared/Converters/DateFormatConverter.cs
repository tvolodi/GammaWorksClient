using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace GammaWorksClient.Shared.Converters
{
    public class DateFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string result;
            DateTimeOffset valueDT;
            if (value != null)
            {
                valueDT = (DateTimeOffset)value;
            }                    
            else return null;

            if(valueDT != DateTimeOffset.MinValue)
            {
                result = valueDT.ToString("yyyy-MM-dd HH:mm");
            } else
            {
                result = "";
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
