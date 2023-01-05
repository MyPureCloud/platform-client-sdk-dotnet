using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Client
{
    internal class UpgradeSdkEnumConverter : JsonConverter
    {
        // Inspired by http://stackoverflow.com/questions/22752075/how-can-i-ignore-unknown-enum-values-during-json-deserialization

        public override bool CanConvert(Type objectType)
        {
            var type = Nullable.GetUnderlyingType(objectType) ?? objectType;
            return type.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var typeInfo = EnumTypeSerializationInfo.FromEnumType(objectType);

            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var enumText = reader.Value.ToString();
                    if (typeInfo.ValuesByString.TryGetValue(enumText, out var result)) return result;
                    break;
                case JsonToken.Integer:
                    var enumVal = Convert.ToInt32(reader.Value);
                    if (typeInfo.ValuesByInt.TryGetValue(enumVal, out result)) return result;
                    break;
            }

            return typeInfo.DefaultValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var typeInfo = EnumTypeSerializationInfo.FromEnumType(value.GetType());
            if (typeInfo.StringsByValue.TryGetValue(value, out var enumText)) writer.WriteValue(enumText);
        }

        private struct EnumTypeSerializationInfo
        {
            private static readonly ConcurrentDictionary<Type, EnumTypeSerializationInfo> Cache = new ConcurrentDictionary<Type, EnumTypeSerializationInfo>(1, 31);

            public static EnumTypeSerializationInfo FromEnumType(Type type)
            {
                type = Nullable.GetUnderlyingType(type) ?? type;
                return Cache.GetOrAdd(type, Build);
            }

            public readonly IReadOnlyDictionary<string, Enum> ValuesByString;

            public readonly IReadOnlyDictionary<int, Enum> ValuesByInt;

            public readonly IReadOnlyDictionary<object, string> StringsByValue;

            public readonly Enum DefaultValue;

            private EnumTypeSerializationInfo(Type type)
            {
                Debug.Assert(type.IsEnum);
                var enumMembers = type.GetFields(BindingFlags.Public | BindingFlags.Static);

                var valuesByString = new Dictionary<string, Enum>(enumMembers.Length, StringComparer.OrdinalIgnoreCase);
                var valuesByInt = new Dictionary<int, Enum>(enumMembers.Length);
                var stringsByValue = new Dictionary<object, string>(enumMembers.Length);
                Enum defaultValue = null;

                foreach (var enumMember in enumMembers)
                {
                    var attribute = enumMember.GetCustomAttribute<EnumMemberAttribute>();
                    if (attribute == null) continue;

                    var enumValue = (Enum)enumMember.GetValue(null);

                    if (attribute.Value == "OUTDATED_SDK_VERSION")
                    {
                        defaultValue = enumValue;
                    }
                    else
                    {
                        valuesByString[attribute.Value] = enumValue;
                        stringsByValue[enumValue] = attribute.Value;

                        var intValue = Convert.ToInt32(enumValue);
                        valuesByInt[intValue] = enumValue;
                    }
                }

                ValuesByString = valuesByString;
                ValuesByInt = valuesByInt;
                StringsByValue = stringsByValue;
                DefaultValue = defaultValue ?? (Enum)Activator.CreateInstance(type);
            }

            private static readonly Func<Type, EnumTypeSerializationInfo> Build = t => new EnumTypeSerializationInfo(t);
        }
    }
}
