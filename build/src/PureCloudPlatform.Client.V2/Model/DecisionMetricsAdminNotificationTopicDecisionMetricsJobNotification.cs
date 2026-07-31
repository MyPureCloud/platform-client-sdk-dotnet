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
    /// DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification :  IEquatable<DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification>
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
        /// Initializes a new instance of the <see cref="DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification" /> class.
        /// </summary>
        /// <param name="Job">Job.</param>
        /// <param name="Status">Status.</param>
        /// <param name="UploadKey">UploadKey.</param>
        /// <param name="UpdateErrors">UpdateErrors.</param>
        public DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification(DecisionMetricsAdminNotificationTopicAddressableEntityRef Job = null, StatusEnum? Status = null, string UploadKey = null, List<DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError> UpdateErrors = null)
        {
            this.Job = Job;
            this.Status = Status;
            this.UploadKey = UploadKey;
            this.UpdateErrors = UpdateErrors;
            
        }
        


        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public DecisionMetricsAdminNotificationTopicAddressableEntityRef Job { get; set; }





        /// <summary>
        /// Gets or Sets UploadKey
        /// </summary>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// Gets or Sets UpdateErrors
        /// </summary>
        [DataMember(Name="updateErrors", EmitDefaultValue=false)]
        public List<DecisionMetricsAdminNotificationTopicDecisionMetricsUpdateError> UpdateErrors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification {\n");

            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  UpdateErrors: ").Append(UpdateErrors).Append("\n");
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
            return this.Equals(obj as DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification);
        }

        /// <summary>
        /// Returns true if DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsAdminNotificationTopicDecisionMetricsJobNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Job == other.Job ||
                    this.Job != null &&
                    this.Job.Equals(other.Job)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.UpdateErrors == other.UpdateErrors ||
                    this.UpdateErrors != null &&
                    this.UpdateErrors.SequenceEqual(other.UpdateErrors)
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
                if (this.Job != null)
                    hash = hash * 59 + this.Job.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.UpdateErrors != null)
                    hash = hash * 59 + this.UpdateErrors.GetHashCode();

                return hash;
            }
        }
    }

}
