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
    /// Information about the channel.
    /// </summary>
    [DataContract]
    public partial class ConversationChannelMetadata :  IEquatable<ConversationChannelMetadata>
    {
        /// <summary>
        /// Channel subtype
        /// </summary>
        /// <value>Channel subtype</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Googlebusinessprofile for "GoogleBusinessProfile"
            /// </summary>
            [EnumMember(Value = "GoogleBusinessProfile")]
            Googlebusinessprofile,
            
            /// <summary>
            /// Enum Roadsideassistance for "RoadsideAssistance"
            /// </summary>
            [EnumMember(Value = "RoadsideAssistance")]
            Roadsideassistance,
            
            /// <summary>
            /// Enum Youtube for "YouTube"
            /// </summary>
            [EnumMember(Value = "YouTube")]
            Youtube
        }
        /// <summary>
        /// Channel subtype
        /// </summary>
        /// <value>Channel subtype</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public SubTypeEnum? SubType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChannelMetadata" /> class.
        /// </summary>
        public ConversationChannelMetadata()
        {
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationChannelMetadata {\n");

            sb.Append("  SubType: ").Append(SubType).Append("\n");
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
            return this.Equals(obj as ConversationChannelMetadata);
        }

        /// <summary>
        /// Returns true if ConversationChannelMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationChannelMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationChannelMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
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
                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();

                return hash;
            }
        }
    }

}
