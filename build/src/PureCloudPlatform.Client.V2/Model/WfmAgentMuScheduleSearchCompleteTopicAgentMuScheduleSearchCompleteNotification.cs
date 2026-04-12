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
    /// WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification :  IEquatable<WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification" /> class.
        /// </summary>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="Error">Error.</param>
        public WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification(string OperationId = null, StatusEnum? Status = null, string DownloadUrl = null, WfmAgentMuScheduleSearchCompleteTopicErrorBody Error = null)
        {
            this.OperationId = OperationId;
            this.Status = Status;
            this.DownloadUrl = DownloadUrl;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }





        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public WfmAgentMuScheduleSearchCompleteTopicErrorBody Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification {\n");

            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentMuScheduleSearchCompleteTopicAgentMuScheduleSearchCompleteNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
