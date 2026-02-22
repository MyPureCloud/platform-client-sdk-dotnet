using System;
using System.Globalization;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Client
{
    ///<Summary>
    /// Extends JSON Converter Class for YearMonth
    ///</Summary>
    public class YearMonthConverter : JsonConverter
    {
        ///<Summary>
        /// Determines if objectType can be converted.
        ///</Summary>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(YearMonth)) || (Nullable.GetUnderlyingType(objectType) == typeof(YearMonth));
        }

        ///<Summary>
        /// Writes YearMonth value to JSON
        ///</Summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            YearMonth ym = (YearMonth) value;
            writer.WriteValue(String.Format("{0:0000}", ym.Year) + "-" + String.Format("{0:00}", ym.Month));
        }

        ///<Summary>
        /// Reads YearMonth value from JSON
        ///</Summary>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var ymText = reader.Value.ToString();
                    string[] ymSubs = ymText.Split('-');
                    if (ymSubs != null && ymSubs.Length == 2)
                    {
                        int year = Int32.Parse(ymSubs[0]);
                        int month = Int32.Parse(ymSubs[1]);
                        YearMonth ymValue = new YearMonth(year,month);
                        return ymValue;
                    }
                    break;
                default:
                    return null;
            }

            return null;
        }
    }
}
