using System;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Client
{
    class UpgradeSdkEnumConverter : JsonConverter
    {
        // Inspired by http://stackoverflow.com/questions/22752075/how-can-i-ignore-unknown-enum-values-during-json-deserialization

        public override bool CanConvert(Type objectType)
        {
            var type = IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            return type.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var isNullable = IsNullableType(objectType);
            var enumType = isNullable ? Nullable.GetUnderlyingType(objectType) : objectType;

            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var enumText = reader.Value.ToString();

                    if (!string.IsNullOrEmpty(enumText))
                    {
                        var enumMembers = enumType.GetMembers();
                        string match = null;

                        foreach (var enumMember in enumMembers)
                        {
                            var memberAttributes = enumMember.GetCustomAttributes(typeof(EnumMemberAttribute), false);
                            if (memberAttributes.Length > 0)
                            {
                                var attribute = memberAttributes.FirstOrDefault() as EnumMemberAttribute;
                                if (string.Equals(attribute.Value, enumText, StringComparison.OrdinalIgnoreCase))
                                {
                                    match = enumMember.Name;
                                    break;
                                }
                            }
                        }

                        if (match != null)
                        {
                            return Enum.Parse(enumType, match);
                        }
                    }
                    break;
                case JsonToken.Integer:
                    var enumVal = Convert.ToInt32(reader.Value);
                    var values = (int[])Enum.GetValues(enumType);
                    if (values.Contains(enumVal))
                    {
                        return Enum.Parse(enumType, enumVal.ToString());
                    }
                    break;
            }

            // See if it has a member named "OUTDATED_SDK_VERSION"
            var names = Enum.GetNames(enumType);
            var outdatedSdkVersionMemberName = names
                .FirstOrDefault(n => string.Equals(n, "OUTDATED_SDK_VERSION", StringComparison.OrdinalIgnoreCase));

            // Return parsed "OUTDATED_SDK_VERSION" member
            return outdatedSdkVersionMemberName != default(string)
                ? Enum.Parse(enumType, outdatedSdkVersionMemberName)
                : Activator.CreateInstance(enumType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var enumMembers = value.GetType().GetMembers();

            foreach (var enumMember in enumMembers)
            {
                var memberAttributes = enumMember.GetCustomAttributes(typeof(EnumMemberAttribute), false);
                if (memberAttributes.Length > 0)
                {
                    var attribute = memberAttributes.FirstOrDefault() as EnumMemberAttribute;
                    if (string.Equals(enumMember.Name, value.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        writer.WriteValue(attribute.Value);
                        return;
                    }
                }
            }
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
}
