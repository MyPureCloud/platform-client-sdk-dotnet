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
    /// V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag
    /// </summary>
    [DataContract]
    public partial class V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag :  IEquatable<V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag>
    {
        /// <summary>
        /// Gets or Sets SentimentLabel
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SentimentLabelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative
        }
        /// <summary>
        /// Gets or Sets SentimentLabel
        /// </summary>
        [DataMember(Name="sentimentLabel", EmitDefaultValue=false)]
        public SentimentLabelEnum? SentimentLabel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag" /> class.
        /// </summary>
        /// <param name="SentimentLabel">SentimentLabel.</param>
        /// <param name="SentimentalPhrase">SentimentalPhrase.</param>
        public V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag(SentimentLabelEnum? SentimentLabel = null, string SentimentalPhrase = null)
        {
            this.SentimentLabel = SentimentLabel;
            this.SentimentalPhrase = SentimentalPhrase;
            
        }
        




        /// <summary>
        /// Gets or Sets SentimentalPhrase
        /// </summary>
        [DataMember(Name="sentimentalPhrase", EmitDefaultValue=false)]
        public string SentimentalPhrase { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag {\n");

            sb.Append("  SentimentLabel: ").Append(SentimentLabel).Append("\n");
            sb.Append("  SentimentalPhrase: ").Append(SentimentalPhrase).Append("\n");
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
            return this.Equals(obj as V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag);
        }

        /// <summary>
        /// Returns true if V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag instances are equal
        /// </summary>
        /// <param name="other">Instance of V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2StaRealtimeCustomerSentimentTopicRealTimeSentimentTag other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SentimentLabel == other.SentimentLabel ||
                    this.SentimentLabel != null &&
                    this.SentimentLabel.Equals(other.SentimentLabel)
                ) &&
                (
                    this.SentimentalPhrase == other.SentimentalPhrase ||
                    this.SentimentalPhrase != null &&
                    this.SentimentalPhrase.Equals(other.SentimentalPhrase)
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
                if (this.SentimentLabel != null)
                    hash = hash * 59 + this.SentimentLabel.GetHashCode();

                if (this.SentimentalPhrase != null)
                    hash = hash * 59 + this.SentimentalPhrase.GetHashCode();

                return hash;
            }
        }
    }

}
