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
    /// Information about a CX infrastructure as code job
    /// </summary>
    [DataContract]
    public partial class InfrastructureascodeJob :  IEquatable<InfrastructureascodeJob>
    {
        /// <summary>
        /// Job status
        /// </summary>
        /// <value>Job status</value>
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
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Running for "Running"
            /// </summary>
            [EnumMember(Value = "Running")]
            Running,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Internalerror for "InternalError"
            /// </summary>
            [EnumMember(Value = "InternalError")]
            Internalerror,
            
            /// <summary>
            /// Enum Incomplete for "Incomplete"
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Rollbackfailed for "RollbackFailed"
            /// </summary>
            [EnumMember(Value = "RollbackFailed")]
            Rollbackfailed,
            
            /// <summary>
            /// Enum Rollbackcomplete for "RollbackComplete"
            /// </summary>
            [EnumMember(Value = "RollbackComplete")]
            Rollbackcomplete
        }
        /// <summary>
        /// Job status
        /// </summary>
        /// <value>Job status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureascodeJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfrastructureascodeJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureascodeJob" /> class.
        /// </summary>
        /// <param name="DryRun">Whether or not the job was a dry run (required).</param>
        public InfrastructureascodeJob(bool? DryRun = null)
        {
            this.DryRun = DryRun;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Whether or not the job was a dry run
        /// </summary>
        /// <value>Whether or not the job was a dry run</value>
        [DataMember(Name="dryRun", EmitDefaultValue=false)]
        public bool? DryRun { get; set; }



        /// <summary>
        /// Accelerator associated with the job
        /// </summary>
        /// <value>Accelerator associated with the job</value>
        [DataMember(Name="acceleratorId", EmitDefaultValue=false)]
        public string AcceleratorId { get; private set; }



        /// <summary>
        /// Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateSubmitted", EmitDefaultValue=false)]
        public DateTime? DateSubmitted { get; private set; }



        /// <summary>
        /// User who submitted the job
        /// </summary>
        /// <value>User who submitted the job</value>
        [DataMember(Name="submittedBy", EmitDefaultValue=false)]
        public UserReference SubmittedBy { get; private set; }





        /// <summary>
        /// Information about errors, if any
        /// </summary>
        /// <value>Information about errors, if any</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorInfo ErrorInfo { get; private set; }



        /// <summary>
        /// The output results of the terraform job
        /// </summary>
        /// <value>The output results of the terraform job</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public string Results { get; private set; }



        /// <summary>
        /// The results of rolling back the job if there were errors.  Not returned if job was successful.
        /// </summary>
        /// <value>The results of rolling back the job if there were errors.  Not returned if job was successful.</value>
        [DataMember(Name="rollbackResults", EmitDefaultValue=false)]
        public string RollbackResults { get; private set; }



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
            sb.Append("class InfrastructureascodeJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  AcceleratorId: ").Append(AcceleratorId).Append("\n");
            sb.Append("  DateSubmitted: ").Append(DateSubmitted).Append("\n");
            sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  RollbackResults: ").Append(RollbackResults).Append("\n");
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
            return this.Equals(obj as InfrastructureascodeJob);
        }

        /// <summary>
        /// Returns true if InfrastructureascodeJob instances are equal
        /// </summary>
        /// <param name="other">Instance of InfrastructureascodeJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfrastructureascodeJob other)
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
                    this.DryRun == other.DryRun ||
                    this.DryRun != null &&
                    this.DryRun.Equals(other.DryRun)
                ) &&
                (
                    this.AcceleratorId == other.AcceleratorId ||
                    this.AcceleratorId != null &&
                    this.AcceleratorId.Equals(other.AcceleratorId)
                ) &&
                (
                    this.DateSubmitted == other.DateSubmitted ||
                    this.DateSubmitted != null &&
                    this.DateSubmitted.Equals(other.DateSubmitted)
                ) &&
                (
                    this.SubmittedBy == other.SubmittedBy ||
                    this.SubmittedBy != null &&
                    this.SubmittedBy.Equals(other.SubmittedBy)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
                ) &&
                (
                    this.RollbackResults == other.RollbackResults ||
                    this.RollbackResults != null &&
                    this.RollbackResults.Equals(other.RollbackResults)
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

                if (this.DryRun != null)
                    hash = hash * 59 + this.DryRun.GetHashCode();

                if (this.AcceleratorId != null)
                    hash = hash * 59 + this.AcceleratorId.GetHashCode();

                if (this.DateSubmitted != null)
                    hash = hash * 59 + this.DateSubmitted.GetHashCode();

                if (this.SubmittedBy != null)
                    hash = hash * 59 + this.SubmittedBy.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.RollbackResults != null)
                    hash = hash * 59 + this.RollbackResults.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
