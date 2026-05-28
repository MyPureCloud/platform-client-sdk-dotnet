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
    /// Summary of an external event definition
    /// </summary>
    [DataContract]
    public partial class ExternalEventSummary :  IEquatable<ExternalEventSummary>
    {
        /// <summary>
        /// The activation status of the external event
        /// </summary>
        /// <value>The activation status of the external event</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivationStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activated for "Activated"
            /// </summary>
            [EnumMember(Value = "Activated")]
            Activated,
            
            /// <summary>
            /// Enum Deactivated for "Deactivated"
            /// </summary>
            [EnumMember(Value = "Deactivated")]
            Deactivated
        }
        /// <summary>
        /// The system status of the external event
        /// </summary>
        /// <value>The system status of the external event</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum New for "New"
            /// </summary>
            [EnumMember(Value = "New")]
            New,
            
            /// <summary>
            /// Enum Updated for "Updated"
            /// </summary>
            [EnumMember(Value = "Updated")]
            Updated,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The activation status of the external event
        /// </summary>
        /// <value>The activation status of the external event</value>
        [DataMember(Name="activationStatus", EmitDefaultValue=false)]
        public ActivationStatusEnum? ActivationStatus { get; private set; }
        /// <summary>
        /// The system status of the external event
        /// </summary>
        /// <value>The system status of the external event</value>
        [DataMember(Name="systemStatus", EmitDefaultValue=false)]
        public SystemStatusEnum? SystemStatus { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventSummary" /> class.
        /// </summary>
        public ExternalEventSummary()
        {
            
        }
        


        /// <summary>
        /// The schema ID of the external event
        /// </summary>
        /// <value>The schema ID of the external event</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; private set; }



        /// <summary>
        /// The name of the external event
        /// </summary>
        /// <value>The name of the external event</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; private set; }



        /// <summary>
        /// The display name of the external event
        /// </summary>
        /// <value>The display name of the external event</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }



        /// <summary>
        /// The rank of the external event
        /// </summary>
        /// <value>The rank of the external event</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; private set; }







        /// <summary>
        /// The timestamp when the external event was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the external event was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The timestamp when the external event was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the external event was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The timestamp when the external event was first activated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the external event was first activated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateFirstActivated", EmitDefaultValue=false)]
        public DateTime? DateFirstActivated { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalEventSummary {\n");

            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  ActivationStatus: ").Append(ActivationStatus).Append("\n");
            sb.Append("  SystemStatus: ").Append(SystemStatus).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateFirstActivated: ").Append(DateFirstActivated).Append("\n");
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
            return this.Equals(obj as ExternalEventSummary);
        }

        /// <summary>
        /// Returns true if ExternalEventSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEventSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEventSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) &&
                (
                    this.ActivationStatus == other.ActivationStatus ||
                    this.ActivationStatus != null &&
                    this.ActivationStatus.Equals(other.ActivationStatus)
                ) &&
                (
                    this.SystemStatus == other.SystemStatus ||
                    this.SystemStatus != null &&
                    this.SystemStatus.Equals(other.SystemStatus)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DateFirstActivated == other.DateFirstActivated ||
                    this.DateFirstActivated != null &&
                    this.DateFirstActivated.Equals(other.DateFirstActivated)
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
                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();

                if (this.ActivationStatus != null)
                    hash = hash * 59 + this.ActivationStatus.GetHashCode();

                if (this.SystemStatus != null)
                    hash = hash * 59 + this.SystemStatus.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateFirstActivated != null)
                    hash = hash * 59 + this.DateFirstActivated.GetHashCode();

                return hash;
            }
        }
    }

}
