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
    /// SourceIntent
    /// </summary>
    [DataContract]
    public partial class SourceIntent :  IEquatable<SourceIntent>
    {
        /// <summary>
        /// Source type
        /// </summary>
        /// <value>Source type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "Bot"
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot,
            
            /// <summary>
            /// Enum Copilot for "Copilot"
            /// </summary>
            [EnumMember(Value = "Copilot")]
            Copilot,
            
            /// <summary>
            /// Enum Digitalbot for "Digitalbot"
            /// </summary>
            [EnumMember(Value = "Digitalbot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Source type
        /// </summary>
        /// <value>Source type</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceIntent" /> class.
        /// </summary>
        /// <param name="SourceIntentId">Id of the source intent.</param>
        /// <param name="SourceIntentName">Name of the source intent.</param>
        /// <param name="SourceType">Source type.</param>
        /// <param name="SourceId">Id of the source.</param>
        /// <param name="SourceName">Name of the source.</param>
        public SourceIntent(string SourceIntentId = null, string SourceIntentName = null, SourceTypeEnum? SourceType = null, string SourceId = null, string SourceName = null)
        {
            this.SourceIntentId = SourceIntentId;
            this.SourceIntentName = SourceIntentName;
            this.SourceType = SourceType;
            this.SourceId = SourceId;
            this.SourceName = SourceName;
            
        }
        


        /// <summary>
        /// Id of the source intent
        /// </summary>
        /// <value>Id of the source intent</value>
        [DataMember(Name="sourceIntentId", EmitDefaultValue=false)]
        public string SourceIntentId { get; set; }



        /// <summary>
        /// Name of the source intent
        /// </summary>
        /// <value>Name of the source intent</value>
        [DataMember(Name="sourceIntentName", EmitDefaultValue=false)]
        public string SourceIntentName { get; set; }





        /// <summary>
        /// Id of the source
        /// </summary>
        /// <value>Id of the source</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }



        /// <summary>
        /// Name of the source
        /// </summary>
        /// <value>Name of the source</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceIntent {\n");

            sb.Append("  SourceIntentId: ").Append(SourceIntentId).Append("\n");
            sb.Append("  SourceIntentName: ").Append(SourceIntentName).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
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
            return this.Equals(obj as SourceIntent);
        }

        /// <summary>
        /// Returns true if SourceIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of SourceIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceIntent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceIntentId == other.SourceIntentId ||
                    this.SourceIntentId != null &&
                    this.SourceIntentId.Equals(other.SourceIntentId)
                ) &&
                (
                    this.SourceIntentName == other.SourceIntentName ||
                    this.SourceIntentName != null &&
                    this.SourceIntentName.Equals(other.SourceIntentName)
                ) &&
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) &&
                (
                    this.SourceName == other.SourceName ||
                    this.SourceName != null &&
                    this.SourceName.Equals(other.SourceName)
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
                if (this.SourceIntentId != null)
                    hash = hash * 59 + this.SourceIntentId.GetHashCode();

                if (this.SourceIntentName != null)
                    hash = hash * 59 + this.SourceIntentName.GetHashCode();

                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                if (this.SourceName != null)
                    hash = hash * 59 + this.SourceName.GetHashCode();

                return hash;
            }
        }
    }

}
