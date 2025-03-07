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
    /// SchedulingStatusResponse
    /// </summary>
    [DataContract]
    public partial class SchedulingStatusResponse :  IEquatable<SchedulingStatusResponse>
    {
        /// <summary>
        /// The status of the scheduling job.
        /// </summary>
        /// <value>The status of the scheduling job.</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Ongoing for "Ongoing"
            /// </summary>
            [EnumMember(Value = "Ongoing")]
            Ongoing,
            
            /// <summary>
            /// Enum Partialfailure for "PartialFailure"
            /// </summary>
            [EnumMember(Value = "PartialFailure")]
            Partialfailure
        }
        /// <summary>
        /// The status of the scheduling job.
        /// </summary>
        /// <value>The status of the scheduling job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingStatusResponse" /> class.
        /// </summary>
        public SchedulingStatusResponse()
        {
            
        }
        


        /// <summary>
        /// The ID generated for the scheduling job.  Use to GET result when job is completed.
        /// </summary>
        /// <value>The ID generated for the scheduling job.  Use to GET result when job is completed.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// If the request could not be properly processed, error details will be given here.
        /// </summary>
        /// <value>If the request could not be properly processed, error details will be given here.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<SchedulingProcessingError> ErrorDetails { get; private set; }



        /// <summary>
        /// The uri of the scheduling result. It has a value if the status is &#39;Success&#39;.
        /// </summary>
        /// <value>The uri of the scheduling result. It has a value if the status is &#39;Success&#39;.</value>
        [DataMember(Name="schedulingResultUri", EmitDefaultValue=false)]
        public string SchedulingResultUri { get; private set; }



        /// <summary>
        /// The percentage of the job that is complete.
        /// </summary>
        /// <value>The percentage of the job that is complete.</value>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public int? PercentComplete { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingStatusResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  SchedulingResultUri: ").Append(SchedulingResultUri).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
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
            return this.Equals(obj as SchedulingStatusResponse);
        }

        /// <summary>
        /// Returns true if SchedulingStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) &&
                (
                    this.SchedulingResultUri == other.SchedulingResultUri ||
                    this.SchedulingResultUri != null &&
                    this.SchedulingResultUri.Equals(other.SchedulingResultUri)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();

                if (this.SchedulingResultUri != null)
                    hash = hash * 59 + this.SchedulingResultUri.GetHashCode();

                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();

                return hash;
            }
        }
    }

}
