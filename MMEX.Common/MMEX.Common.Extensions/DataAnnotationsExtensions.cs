using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace MMEX.Common.Extensions
{
    public class DataAnnotationsExtensions
    {
        public static string GetDescription(Enum enumValue)
        {
            DisplayAttribute attribute = enumValue.GetType()
                .GetRuntimeField(enumValue.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .SingleOrDefault() as DisplayAttribute;
            return attribute == null ? enumValue.ToString() : attribute.Description;
        }

        public static string GetName(Enum enumValue)
        {
            DisplayAttribute attribute = enumValue.GetType()
                .GetRuntimeField(enumValue.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .SingleOrDefault() as DisplayAttribute;
            return attribute == null ? enumValue.ToString() : attribute.Name;
        }

        public static string GetShortName(Enum enumValue)
        {
            DisplayAttribute attribute = enumValue.GetType()
                .GetRuntimeField(enumValue.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .SingleOrDefault() as DisplayAttribute;
            return attribute == null ? enumValue.ToString() : attribute.ShortName;
        }
    }
}
