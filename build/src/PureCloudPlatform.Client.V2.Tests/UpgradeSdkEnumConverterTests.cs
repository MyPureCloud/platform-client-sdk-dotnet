using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Tests
{
    [TestFixture]
    public class UpgradeSdkEnumConverterTests
    {
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,

            [EnumMember(Value = "alerting")]
            Alerting,

            [EnumMember(Value = "delivery-success")]
            Deliverysuccess,

            [EnumMember(Value = "none")]
            None
        }

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

        [TestCase("alerting", ExpectedResult = TestEnum.Alerting)]
        [TestCase("AlErTiNg", ExpectedResult = TestEnum.Alerting)]
        [TestCase("delivery-success", ExpectedResult = TestEnum.Deliverysuccess)]
        [TestCase(nameof(TestEnum.Deliverysuccess), ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase("foo", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        [TestCase("", ExpectedResult = TestEnum.OutdatedSdkVersion)]
        public TestEnum TestReadString(string value)
        {
            var jValue = new JValue(value);
            var reader = jValue.CreateReader();
            var serializer = JsonSerializer.CreateDefault();
            return serializer.Deserialize<TestEnum>(reader);
        }

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

        [TestCase(TestEnum.Deliverysuccess, ExpectedResult = "\"delivery-success\"")]
        [TestCase(256, ExpectedResult = "")]
        public string TestWrite(TestEnum value)
        {
            return JsonConvert.SerializeObject(value);
        }

        [TestCase(TestEnum.Deliverysuccess, ExpectedResult = "\"delivery-success\"")]
        [TestCase(null, ExpectedResult = "null")]
        public string TestWriteNullable(TestEnum? value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}