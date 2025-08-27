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
    /// AdditionalMatchCriteria
    /// </summary>
    [DataContract]
    public partial class AdditionalMatchCriteria :  IEquatable<AdditionalMatchCriteria>
    {
        /// <summary>
        /// Escalate message based on media presence. Not setting any value will escalate all types of msg.
        /// </summary>
        /// <value>Escalate message based on media presence. Not setting any value will escalate all types of msg.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaFilterEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Withmedia for "WithMedia"
            /// </summary>
            [EnumMember(Value = "WithMedia")]
            Withmedia,
            
            /// <summary>
            /// Enum Withoutmedia for "WithoutMedia"
            /// </summary>
            [EnumMember(Value = "WithoutMedia")]
            Withoutmedia
        }
        /// <summary>
        /// Escalate message based on media presence. Not setting any value will escalate all types of msg.
        /// </summary>
        /// <value>Escalate message based on media presence. Not setting any value will escalate all types of msg.</value>
        [DataMember(Name="mediaFilter", EmitDefaultValue=false)]
        public MediaFilterEnum? MediaFilter { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalMatchCriteria" /> class.
        /// </summary>
        /// <param name="Topics">List of topics with specific data ingestion rules to filter messages for escalation..</param>
        /// <param name="MediaFilter">Escalate message based on media presence. Not setting any value will escalate all types of msg..</param>
        public AdditionalMatchCriteria(List<TopicCriteria> Topics = null, MediaFilterEnum? MediaFilter = null)
        {
            this.Topics = Topics;
            this.MediaFilter = MediaFilter;
            
        }
        


        /// <summary>
        /// List of topics with specific data ingestion rules to filter messages for escalation.
        /// </summary>
        /// <value>List of topics with specific data ingestion rules to filter messages for escalation.</value>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<TopicCriteria> Topics { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalMatchCriteria {\n");

            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  MediaFilter: ").Append(MediaFilter).Append("\n");
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
            return this.Equals(obj as AdditionalMatchCriteria);
        }

        /// <summary>
        /// Returns true if AdditionalMatchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalMatchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalMatchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Topics == other.Topics ||
                    this.Topics != null &&
                    this.Topics.SequenceEqual(other.Topics)
                ) &&
                (
                    this.MediaFilter == other.MediaFilter ||
                    this.MediaFilter != null &&
                    this.MediaFilter.Equals(other.MediaFilter)
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
                if (this.Topics != null)
                    hash = hash * 59 + this.Topics.GetHashCode();

                if (this.MediaFilter != null)
                    hash = hash * 59 + this.MediaFilter.GetHashCode();

                return hash;
            }
        }
    }

}
