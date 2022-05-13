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
    /// WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate :  IEquatable<WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate>
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
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        public WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate(StatusEnum? Status = null)
        {
            this.Status = Status;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate {\n");

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
            return this.Equals(obj as WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate);
        }

        /// <summary>
        /// Returns true if WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
