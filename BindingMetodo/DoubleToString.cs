﻿using System;
using System.Windows.Data;

namespace BindingMetodo
{
    public class DoubleToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return value.ToString();
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = value as string;
            if (strValue != null)
            {
                double result;
                bool converted = Double.TryParse(strValue, out result);
                if (converted)
                {
                    return result;
                }
            }
            return null;
        }
    }
    public enum DistanceType
    {
        Miles,
        Kilometres
    }
}
