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
    /// WfmBuScheduleRunTopicSchedulerMessageSeverityCount
    /// </summary>
    [DataContract]
    public partial class WfmBuScheduleRunTopicSchedulerMessageSeverityCount :  IEquatable<WfmBuScheduleRunTopicSchedulerMessageSeverityCount>
    {
        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ignore for "Ignore"
            /// </summary>
            [EnumMember(Value = "Ignore")]
            Ignore,
            
            /// <summary>
            /// Enum Information for "Information"
            /// </summary>
            [EnumMember(Value = "Information")]
            Information,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuScheduleRunTopicSchedulerMessageSeverityCount" /> class.
        /// </summary>
        /// <param name="Severity">Severity.</param>
        /// <param name="Count">Count.</param>
        public WfmBuScheduleRunTopicSchedulerMessageSeverityCount(SeverityEnum? Severity = null, int? Count = null)
        {
            this.Severity = Severity;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuScheduleRunTopicSchedulerMessageSeverityCount {\n");

            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(obj as WfmBuScheduleRunTopicSchedulerMessageSeverityCount);
        }

        /// <summary>
        /// Returns true if WfmBuScheduleRunTopicSchedulerMessageSeverityCount instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuScheduleRunTopicSchedulerMessageSeverityCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuScheduleRunTopicSchedulerMessageSeverityCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Severity == other.Severity ||
                    this.Severity != null &&
                    this.Severity.Equals(other.Severity)
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
                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
