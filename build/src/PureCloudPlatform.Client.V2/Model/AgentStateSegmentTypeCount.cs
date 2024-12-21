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
    /// AgentStateSegmentTypeCount
    /// </summary>
    [DataContract]
    public partial class AgentStateSegmentTypeCount :  IEquatable<AgentStateSegmentTypeCount>
    {
        /// <summary>
        /// Segment type
        /// </summary>
        /// <value>Segment type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SegmentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alert for "alert"
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert,
            
            /// <summary>
            /// Enum Barging for "barging"
            /// </summary>
            [EnumMember(Value = "barging")]
            Barging,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Coaching for "coaching"
            /// </summary>
            [EnumMember(Value = "coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Delay for "delay"
            /// </summary>
            [EnumMember(Value = "delay")]
            Delay,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Hold for "hold"
            /// </summary>
            [EnumMember(Value = "hold")]
            Hold,
            
            /// <summary>
            /// Enum Interact for "interact"
            /// </summary>
            [EnumMember(Value = "interact")]
            Interact,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Monitoring for "monitoring"
            /// </summary>
            [EnumMember(Value = "monitoring")]
            Monitoring,
            
            /// <summary>
            /// Enum Parked for "parked"
            /// </summary>
            [EnumMember(Value = "parked")]
            Parked,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Sharing for "sharing"
            /// </summary>
            [EnumMember(Value = "sharing")]
            Sharing,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Wrapup for "wrapup"
            /// </summary>
            [EnumMember(Value = "wrapup")]
            Wrapup
        }
        /// <summary>
        /// Segment type
        /// </summary>
        /// <value>Segment type</value>
        [DataMember(Name="segmentType", EmitDefaultValue=false)]
        public SegmentTypeEnum? SegmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateSegmentTypeCount" /> class.
        /// </summary>
        /// <param name="SegmentType">Segment type.</param>
        /// <param name="Count">Count of segment type.</param>
        public AgentStateSegmentTypeCount(SegmentTypeEnum? SegmentType = null, int? Count = null)
        {
            this.SegmentType = SegmentType;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Count of segment type
        /// </summary>
        /// <value>Count of segment type</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateSegmentTypeCount {\n");

            sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStateSegmentTypeCount);
        }

        /// <summary>
        /// Returns true if AgentStateSegmentTypeCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateSegmentTypeCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateSegmentTypeCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SegmentType == other.SegmentType ||
                    this.SegmentType != null &&
                    this.SegmentType.Equals(other.SegmentType)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.SegmentType != null)
                    hash = hash * 59 + this.SegmentType.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
