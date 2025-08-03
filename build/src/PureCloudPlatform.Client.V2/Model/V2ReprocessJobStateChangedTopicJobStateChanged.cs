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
    /// V2ReprocessJobStateChangedTopicJobStateChanged
    /// </summary>
    [DataContract]
    public partial class V2ReprocessJobStateChangedTopicJobStateChanged :  IEquatable<V2ReprocessJobStateChangedTopicJobStateChanged>
    {
        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum JobStatusEnum
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
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="jobStatus", EmitDefaultValue=false)]
        public JobStatusEnum? JobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ReprocessJobStateChangedTopicJobStateChanged" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="JobId">JobId.</param>
        /// <param name="JobStatus">JobStatus.</param>
        /// <param name="ProcessedInteractionsCount">ProcessedInteractionsCount.</param>
        /// <param name="FailedInteractionsCount">FailedInteractionsCount.</param>
        /// <param name="TotalInteractions">TotalInteractions.</param>
        public V2ReprocessJobStateChangedTopicJobStateChanged(string OrganizationId = null, string JobId = null, JobStatusEnum? JobStatus = null, long? ProcessedInteractionsCount = null, long? FailedInteractionsCount = null, long? TotalInteractions = null)
        {
            this.OrganizationId = OrganizationId;
            this.JobId = JobId;
            this.JobStatus = JobStatus;
            this.ProcessedInteractionsCount = ProcessedInteractionsCount;
            this.FailedInteractionsCount = FailedInteractionsCount;
            this.TotalInteractions = TotalInteractions;
            
        }
        


        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }





        /// <summary>
        /// Gets or Sets ProcessedInteractionsCount
        /// </summary>
        [DataMember(Name="processedInteractionsCount", EmitDefaultValue=false)]
        public long? ProcessedInteractionsCount { get; set; }



        /// <summary>
        /// Gets or Sets FailedInteractionsCount
        /// </summary>
        [DataMember(Name="failedInteractionsCount", EmitDefaultValue=false)]
        public long? FailedInteractionsCount { get; set; }



        /// <summary>
        /// Gets or Sets TotalInteractions
        /// </summary>
        [DataMember(Name="totalInteractions", EmitDefaultValue=false)]
        public long? TotalInteractions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ReprocessJobStateChangedTopicJobStateChanged {\n");

            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ProcessedInteractionsCount: ").Append(ProcessedInteractionsCount).Append("\n");
            sb.Append("  FailedInteractionsCount: ").Append(FailedInteractionsCount).Append("\n");
            sb.Append("  TotalInteractions: ").Append(TotalInteractions).Append("\n");
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
            return this.Equals(obj as V2ReprocessJobStateChangedTopicJobStateChanged);
        }

        /// <summary>
        /// Returns true if V2ReprocessJobStateChangedTopicJobStateChanged instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ReprocessJobStateChangedTopicJobStateChanged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ReprocessJobStateChangedTopicJobStateChanged other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.JobStatus == other.JobStatus ||
                    this.JobStatus != null &&
                    this.JobStatus.Equals(other.JobStatus)
                ) &&
                (
                    this.ProcessedInteractionsCount == other.ProcessedInteractionsCount ||
                    this.ProcessedInteractionsCount != null &&
                    this.ProcessedInteractionsCount.Equals(other.ProcessedInteractionsCount)
                ) &&
                (
                    this.FailedInteractionsCount == other.FailedInteractionsCount ||
                    this.FailedInteractionsCount != null &&
                    this.FailedInteractionsCount.Equals(other.FailedInteractionsCount)
                ) &&
                (
                    this.TotalInteractions == other.TotalInteractions ||
                    this.TotalInteractions != null &&
                    this.TotalInteractions.Equals(other.TotalInteractions)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.JobStatus != null)
                    hash = hash * 59 + this.JobStatus.GetHashCode();

                if (this.ProcessedInteractionsCount != null)
                    hash = hash * 59 + this.ProcessedInteractionsCount.GetHashCode();

                if (this.FailedInteractionsCount != null)
                    hash = hash * 59 + this.FailedInteractionsCount.GetHashCode();

                if (this.TotalInteractions != null)
                    hash = hash * 59 + this.TotalInteractions.GetHashCode();

                return hash;
            }
        }
    }

}
