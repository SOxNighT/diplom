using Google.Protobuf.WellKnownTypes;
using System;
using System.ComponentModel;
using System.Reflection;
using Tinkoff.InvestApi.V1;

namespace Main.Extensions
{
    /// <summary>
    /// Расширение Enum
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Получить атрибут "Описание"
        /// </summary>
        /// <param name="value">Значение перечисления</param>
        /// <returns>Значение атрибута "Описание"</returns>
        public static string GetDescription(this System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        /// <summary>
        /// Получить атрибут "Quotation"
        /// </summary>
        /// <param name="value">Значение Quotation</param>
        /// <returns>Значение атрибута "Quotation"</returns>
        public static string GetQuotationDescription(this Quotation value)
        {
            if (value == null)
            {
                return $"0.0";
            }
            return $"{value.Units}.{value.Nano}";
        }

        /// <summary>
        /// Получить атрибут "Timestamp"
        /// </summary>
        /// <param name="value">Значение Timestamp</param>
        /// <returns>Значение атрибута "Timestamp"</returns>
        public static string GetTimestampDescription(this Timestamp value)
        {
            if (value == null)
            {
                return $"{DateTime.MinValue}";
            }
            return $"{value.ToDateTime()}";
        }

        /// <summary>
        /// Получить атрибут "MoneyValue"
        /// </summary>
        /// <param name="value">Значение MoneyValue</param>
        /// <returns>Значение атрибута "MoneyValue"</returns>
        public static string GetMoneyValueDescription(this MoneyValue value)
        {
            if (value == null)
            {
                return $"usd 0.0";
            }
            return $"{value.Currency} {value.Units}.{value.Nano}";
        }
    }
}