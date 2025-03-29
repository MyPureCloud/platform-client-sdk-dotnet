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
    /// WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity :  IEquatable<WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity>
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReasonEnum
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
            /// Enum Deleteinprogress for "DeleteInProgress"
            /// </summary>
            [EnumMember(Value = "DeleteInProgress")]
            Deleteinprogress,
            
            /// <summary>
            /// Enum Validationinprogress for "ValidationInProgress"
            /// </summary>
            [EnumMember(Value = "ValidationInProgress")]
            Validationinprogress,
            
            /// <summary>
            /// Enum Requestidnotfound for "RequestIdNotFound"
            /// </summary>
            [EnumMember(Value = "RequestIdNotFound")]
            Requestidnotfound,
            
            /// <summary>
            /// Enum Invalidrequest for "InvalidRequest"
            /// </summary>
            [EnumMember(Value = "InvalidRequest")]
            Invalidrequest
        }
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity" /> class.
        /// </summary>
        /// <param name="RequestId">RequestId.</param>
        /// <param name="Reason">Reason.</param>
        public WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity(string RequestId = null, ReasonEnum? Reason = null)
        {
            this.RequestId = RequestId;
            this.Reason = Reason;
            
        }
        


        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity {\n");

            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity);
        }

        /// <summary>
        /// Returns true if WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                return hash;
            }
        }
    }

}
