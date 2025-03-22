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
    /// SocialMediaMessageEscalationInfo
    /// </summary>
    [DataContract]
    public partial class SocialMediaMessageEscalationInfo :  IEquatable<SocialMediaMessageEscalationInfo>
    {
        /// <summary>
        /// Gets or Sets EscalationStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EscalationStatusEnum
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
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Throttled for "Throttled"
            /// </summary>
            [EnumMember(Value = "Throttled")]
            Throttled,
            
            /// <summary>
            /// Enum Previouslyescalated for "PreviouslyEscalated"
            /// </summary>
            [EnumMember(Value = "PreviouslyEscalated")]
            Previouslyescalated,
            
            /// <summary>
            /// Enum Notescalated for "NotEscalated"
            /// </summary>
            [EnumMember(Value = "NotEscalated")]
            Notescalated,
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic
        }
        /// <summary>
        /// Gets or Sets EscalationStatus
        /// </summary>
        [DataMember(Name="escalationStatus", EmitDefaultValue=false)]
        public EscalationStatusEnum? EscalationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaMessageEscalationInfo" /> class.
        /// </summary>
        /// <param name="EscalationStatus">EscalationStatus.</param>
        public SocialMediaMessageEscalationInfo(EscalationStatusEnum? EscalationStatus = null)
        {
            this.EscalationStatus = EscalationStatus;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaMessageEscalationInfo {\n");

            sb.Append("  EscalationStatus: ").Append(EscalationStatus).Append("\n");
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
            return this.Equals(obj as SocialMediaMessageEscalationInfo);
        }

        /// <summary>
        /// Returns true if SocialMediaMessageEscalationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaMessageEscalationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaMessageEscalationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EscalationStatus == other.EscalationStatus ||
                    this.EscalationStatus != null &&
                    this.EscalationStatus.Equals(other.EscalationStatus)
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
                if (this.EscalationStatus != null)
                    hash = hash * 59 + this.EscalationStatus.GetHashCode();

                return hash;
            }
        }
    }

}
