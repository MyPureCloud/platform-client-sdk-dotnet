using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Tests
{
    ///<Summary>
    /// Tests for Enumeration Converter
    ///</Summary>
    [TestFixture]
    public class UpgradeSdkEnumConverterTests
    {
        ///<Summary>
        /// Enumeration for Test
        ///</Summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TestEnum
        {
            ///<Summary>
            /// OutdatedSdkVersion
            ///</Summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,

            ///<Summary>
            /// Alerting
            ///</Summary>
            [EnumMember(Value = "alerting")]
            Alerting,

            ///<Summary>
            /// Deliverysuccess
            ///</Summary>
            [EnumMember(Value = "delivery-success")]
            Deliverysuccess,

            ///<Summary>
            /// None
            ///</Summary>
            [EnumMember(Value = "none")]
            None
        }

        ///<Summary>
        /// Test to Read Int32
        ///</Summary>
        [TestCase(0, ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase(1, ExpectedResult = TestEnum.Alerting)]
        [TestCase(256, ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase(-1, ExpectedResult = TestEnum.OutdatedSdkVersion)]
        public TestEnum TestReadInt32(int value)
        {
            var jValue = new JValue(value);
            var reader = jValue.CreateReader();
            var serializer = JsonSerializer.CreateDefault();
            return serializer.Deserialize<TestEnum>(reader);
        }

        ///<Summary>
        /// Test to Read String
        ///</Summary>
        [TestCase("alerting", ExpectedResult = TestEnum.Alerting)]
        [TestCase("AlErTiNg", ExpectedResult = TestEnum.Alerting)]
        [TestCase("delivery-success", ExpectedResult = TestEnum.Deliverysuccess)]
        [TestCase(nameof(TestEnum.Deliverysuccess), ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase("OUTDATED_SDK_VERSION", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase("foo", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase("", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        public TestEnum TestReadString(string value)
        {
            var jValue = new JValue(value);
            var reader = jValue.CreateReader();
            var serializer = JsonSerializer.CreateDefault();
            return serializer.Deserialize<TestEnum>(reader);
        }

        ///<Summary>
        /// Test to Read String Nullable
        ///</Summary>
        [TestCase("alerting", ExpectedResult = TestEnum.Alerting)]
        [TestCase("", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase(null, ExpectedResult = TestEnum.OutdatedSdkVersion)]
        public TestEnum? TestReadStringNullable(string value)
        {
            var jValue = value == null ? JValue.CreateNull() : new JValue(value);
            var reader = jValue.CreateReader();
            var serializer = JsonSerializer.CreateDefault();
            return serializer.Deserialize<TestEnum?>(reader);
        }

        ///<Summary>
        /// Test to Write
        ///</Summary>
        [TestCase(TestEnum.Deliverysuccess, ExpectedResult = "\"delivery-success\"")]
        [TestCase(TestEnum.OutdatedSdkVersion, ExpectedResult = "\"OUTDATED_SDK_VERSION\"")]
        [TestCase(256, ExpectedResult = "")]
        public string TestWrite(TestEnum value)
        {
            return JsonConvert.SerializeObject(value);
        }

        ///<Summary>
        /// Test to Write Nullable
        ///</Summary>
        [TestCase(TestEnum.Deliverysuccess, ExpectedResult = "\"delivery-success\"")]
        [TestCase(TestEnum.OutdatedSdkVersion, ExpectedResult = "\"OUTDATED_SDK_VERSION\"")]
        [TestCase(null, ExpectedResult = "null")]
        public string TestWriteNullable(TestEnum? value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}