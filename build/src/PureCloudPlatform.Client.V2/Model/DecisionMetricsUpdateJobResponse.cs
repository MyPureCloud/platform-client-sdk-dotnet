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
    /// DecisionMetricsUpdateJobResponse
    /// </summary>
    [DataContract]
    public partial class DecisionMetricsUpdateJobResponse :  IEquatable<DecisionMetricsUpdateJobResponse>
    {
        /// <summary>
        /// The status of the update job
        /// </summary>
        /// <value>The status of the update job</value>
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
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// The status of the update job
        /// </summary>
        /// <value>The status of the update job</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateJobResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionMetricsUpdateJobResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionMetricsUpdateJobResponse" /> class.
        /// </summary>
        /// <param name="UploadKey">The S3 key for the uploaded decision metrics file (required).</param>
        /// <param name="Job">The update job (required).</param>
        /// <param name="Status">The status of the update job (required).</param>
        /// <param name="Metadata">The metadata of the update job (required).</param>
        /// <param name="UpdateErrors">Errors occurred during update process, which will be non empty when status is &#x60;Error&#x60; (required).</param>
        public DecisionMetricsUpdateJobResponse(string UploadKey = null, DecisionMetricsJobReference Job = null, StatusEnum? Status = null, WfmEntityMetadata Metadata = null, List<DecisionMetricsUpdateError> UpdateErrors = null)
        {
            this.UploadKey = UploadKey;
            this.Job = Job;
            this.Status = Status;
            this.Metadata = Metadata;
            this.UpdateErrors = UpdateErrors;
            
        }
        


        /// <summary>
        /// The S3 key for the uploaded decision metrics file
        /// </summary>
        /// <value>The S3 key for the uploaded decision metrics file</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// The update job
        /// </summary>
        /// <value>The update job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public DecisionMetricsJobReference Job { get; set; }





        /// <summary>
        /// The metadata of the update job
        /// </summary>
        /// <value>The metadata of the update job</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmEntityMetadata Metadata { get; set; }



        /// <summary>
        /// Errors occurred during update process, which will be non empty when status is &#x60;Error&#x60;
        /// </summary>
        /// <value>Errors occurred during update process, which will be non empty when status is &#x60;Error&#x60;</value>
        [DataMember(Name="updateErrors", EmitDefaultValue=false)]
        public List<DecisionMetricsUpdateError> UpdateErrors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionMetricsUpdateJobResponse {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as DecisionMetricsUpdateJobResponse);
        }

        /// <summary>
        /// Returns true if DecisionMetricsUpdateJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionMetricsUpdateJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionMetricsUpdateJobResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
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
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.Job != null)
                    hash = hash * 59 + this.Job.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.UpdateErrors != null)
                    hash = hash * 59 + this.UpdateErrors.GetHashCode();

                return hash;
            }
        }
    }

}
