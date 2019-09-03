﻿
namespace TCC.Domain.Objects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    public class EnumHelper
    {
        public static T GetEnumObjectByValue<T>(int valueId)
        {
            return (T)Enum.ToObject(typeof(T), valueId);
        }

        public static string GetEnumDescriptionByValue<T>(int valueId)
        {
            var enumT = (Enum)Enum.ToObject(typeof(T), valueId);
            var description = GetEnumDescription(enumT);
            return description;
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > byte.MinValue) ? attributes[byte.MinValue].Description : value.ToString();

        }

        public static object GetEnumDescriptionList<T>()
        {            
            var type = typeof(T);
            if (!type.GetTypeInfo().IsEnum)
            {
                throw new ArgumentException();
            }

            var field = type.GetFields();
            return field.SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new { Field = f, Att = a })
                                         .Select(a => new { Id = a.Field?.GetRawConstantValue(), Descricao = ((DescriptionAttribute)a.Att).Description })
                                         .ToList();
        }

        public static int GetInteger(Enum Enumerador)
        {
            return Enumerador.GetHashCode();
        }


        public static int GetEnumValueByDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.GetTypeInfo().IsEnum)
            {
                throw new ArgumentException();
            }

            var field = type.GetFields().SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new { Field = f, Att = a })
                                        .Where(a => ((DescriptionAttribute)a.Att).Description == description).SingleOrDefault();

            var retorno = (T)field.Field.GetRawConstantValue();

            return field == null ? 0 : Convert.ToInt32(retorno);
        }
    }
}
