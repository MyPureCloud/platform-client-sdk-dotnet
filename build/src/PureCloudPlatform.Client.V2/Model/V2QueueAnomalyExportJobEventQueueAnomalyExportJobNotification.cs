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
    /// V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification
    /// </summary>
    [DataContract]
    public partial class V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification :  IEquatable<V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
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
        /// Initializes a new instance of the <see cref="V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        public V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification(string JobId = null, StatusEnum? Status = null, string DownloadUrl = null)
        {
            this.JobId = JobId;
            this.Status = Status;
            this.DownloadUrl = DownloadUrl;
            
        }
        


        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }





        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification {\n");

            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification);
        }

        /// <summary>
        /// Returns true if V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2QueueAnomalyExportJobEventQueueAnomalyExportJobNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
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
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
