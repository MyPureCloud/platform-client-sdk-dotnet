using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TestTopicPhrasePhrase
    /// </summary>
    [DataContract]
    public partial class TestTopicPhrasePhrase :  IEquatable<TestTopicPhrasePhrase>
    {
        /// <summary>
        /// The phrase strictness, default value is null
        /// </summary>
        /// <value>The phrase strictness, default value is null</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StrictnessEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _55 for "55"
            /// </summary>
            [EnumMember(Value = "55")]
            _55,
            
            /// <summary>
            /// Enum _65 for "65"
            /// </summary>
            [EnumMember(Value = "65")]
            _65,
            
            /// <summary>
            /// Enum _72 for "72"
            /// </summary>
            [EnumMember(Value = "72")]
            _72,
            
            /// <summary>
            /// Enum _85 for "85"
            /// </summary>
            [EnumMember(Value = "85")]
            _85,
            
            /// <summary>
            /// Enum _90 for "90"
            /// </summary>
            [EnumMember(Value = "90")]
            _90
        }
        /// <summary>
        /// The phrase strictness, default value is null
        /// </summary>
        /// <value>The phrase strictness, default value is null</value>
        [DataMember(Name="strictness", EmitDefaultValue=false)]
        public StrictnessEnum? Strictness { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestTopicPhrasePhrase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestTopicPhrasePhrase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestTopicPhrasePhrase" /> class.
        /// </summary>
        /// <param name="Text">The phrase text (required).</param>
        /// <param name="Strictness">The phrase strictness, default value is null.</param>
        public TestTopicPhrasePhrase(string Text = null, StrictnessEnum? Strictness = null)
        {
            this.Text = Text;
            this.Strictness = Strictness;
            
        }
        


        /// <summary>
        /// The phrase text
        /// </summary>
        /// <value>The phrase text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestTopicPhrasePhrase {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Strictness: ").Append(Strictness).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TestTopicPhrasePhrase);
        }

        /// <summary>
        /// Returns true if TestTopicPhrasePhrase instances are equal
        /// </summary>
        /// <param name="other">Instance of TestTopicPhrasePhrase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestTopicPhrasePhrase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Strictness == other.Strictness ||
                    this.Strictness != null &&
                    this.Strictness.Equals(other.Strictness)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Strictness != null)
                    hash = hash * 59 + this.Strictness.GetHashCode();

                return hash;
            }
        }
    }

}
