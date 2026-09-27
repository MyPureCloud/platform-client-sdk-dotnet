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
    /// BulkUpdateAgentUnavailableTimesResultItem
    /// </summary>
    [DataContract]
    public partial class BulkUpdateAgentUnavailableTimesResultItem :  IEquatable<BulkUpdateAgentUnavailableTimesResultItem>
    {
        /// <summary>
        /// The status of the operation
        /// </summary>
        /// <value>The status of the operation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Skipped for "Skipped"
            /// </summary>
            [EnumMember(Value = "Skipped")]
            Skipped
        }
        /// <summary>
        /// The status of the operation
        /// </summary>
        /// <value>The status of the operation</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateAgentUnavailableTimesResultItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkUpdateAgentUnavailableTimesResultItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateAgentUnavailableTimesResultItem" /> class.
        /// </summary>
        /// <param name="UnavailableTime">The unavailable time that was created, updated, or deleted. Populated when the operation completed successfully.</param>
        /// <param name="Status">The status of the operation (required).</param>
        public BulkUpdateAgentUnavailableTimesResultItem(TargetUnavailableTime UnavailableTime = null, StatusEnum? Status = null)
        {
            this.UnavailableTime = UnavailableTime;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// The unavailable time that was created, updated, or deleted. Populated when the operation completed successfully
        /// </summary>
        /// <value>The unavailable time that was created, updated, or deleted. Populated when the operation completed successfully</value>
        [DataMember(Name="unavailableTime", EmitDefaultValue=false)]
        public TargetUnavailableTime UnavailableTime { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateAgentUnavailableTimesResultItem {\n");

            sb.Append("  UnavailableTime: ").Append(UnavailableTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as BulkUpdateAgentUnavailableTimesResultItem);
        }

        /// <summary>
        /// Returns true if BulkUpdateAgentUnavailableTimesResultItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateAgentUnavailableTimesResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateAgentUnavailableTimesResultItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UnavailableTime == other.UnavailableTime ||
                    this.UnavailableTime != null &&
                    this.UnavailableTime.Equals(other.UnavailableTime)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.UnavailableTime != null)
                    hash = hash * 59 + this.UnavailableTime.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
