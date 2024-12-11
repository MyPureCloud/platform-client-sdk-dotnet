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
    /// BatchDownloadJobStatusResult
    /// </summary>
    [DataContract]
    public partial class BatchDownloadJobStatusResult :  IEquatable<BatchDownloadJobStatusResult>
    {
        /// <summary>
        /// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
        /// </summary>
        /// <value>Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.</value>
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
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed
        }
        /// <summary>
        /// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
        /// </summary>
        /// <value>Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDownloadJobStatusResult" /> class.
        /// </summary>
        /// <param name="JobId">JobId returned when job was initially submitted..</param>
        /// <param name="ExpectedResultCount">Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed..</param>
        /// <param name="ResultCount">Current number of results available, this includes both success and error results..</param>
        /// <param name="ErrorCount">Current number of error results..</param>
        /// <param name="Status">Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled..</param>
        /// <param name="Results">Current set of results for the job..</param>
        public BatchDownloadJobStatusResult(string JobId = null, int? ExpectedResultCount = null, int? ResultCount = null, int? ErrorCount = null, StatusEnum? Status = null, List<BatchDownloadJobResult> Results = null)
        {
            this.JobId = JobId;
            this.ExpectedResultCount = ExpectedResultCount;
            this.ResultCount = ResultCount;
            this.ErrorCount = ErrorCount;
            this.Status = Status;
            this.Results = Results;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// JobId returned when job was initially submitted.
        /// </summary>
        /// <value>JobId returned when job was initially submitted.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }



        /// <summary>
        /// Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed.
        /// </summary>
        /// <value>Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed.</value>
        [DataMember(Name="expectedResultCount", EmitDefaultValue=false)]
        public int? ExpectedResultCount { get; set; }



        /// <summary>
        /// Current number of results available, this includes both success and error results.
        /// </summary>
        /// <value>Current number of results available, this includes both success and error results.</value>
        [DataMember(Name="resultCount", EmitDefaultValue=false)]
        public int? ResultCount { get; set; }



        /// <summary>
        /// Current number of error results.
        /// </summary>
        /// <value>Current number of error results.</value>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }





        /// <summary>
        /// Current set of results for the job.
        /// </summary>
        /// <value>Current set of results for the job.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BatchDownloadJobResult> Results { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDownloadJobStatusResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ExpectedResultCount: ").Append(ExpectedResultCount).Append("\n");
            sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as BatchDownloadJobStatusResult);
        }

        /// <summary>
        /// Returns true if BatchDownloadJobStatusResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchDownloadJobStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDownloadJobStatusResult other)
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
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.ExpectedResultCount == other.ExpectedResultCount ||
                    this.ExpectedResultCount != null &&
                    this.ExpectedResultCount.Equals(other.ExpectedResultCount)
                ) &&
                (
                    this.ResultCount == other.ResultCount ||
                    this.ResultCount != null &&
                    this.ResultCount.Equals(other.ResultCount)
                ) &&
                (
                    this.ErrorCount == other.ErrorCount ||
                    this.ErrorCount != null &&
                    this.ErrorCount.Equals(other.ErrorCount)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.ExpectedResultCount != null)
                    hash = hash * 59 + this.ExpectedResultCount.GetHashCode();

                if (this.ResultCount != null)
                    hash = hash * 59 + this.ResultCount.GetHashCode();

                if (this.ErrorCount != null)
                    hash = hash * 59 + this.ErrorCount.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
