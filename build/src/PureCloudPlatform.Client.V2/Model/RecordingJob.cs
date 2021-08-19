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
    /// RecordingJob
    /// </summary>
    [DataContract]
    public partial class RecordingJob :  IEquatable<RecordingJob>
    {
        
        
        
        
        
        /// <summary>
        /// The current state of the job.
        /// </summary>
        /// <value>The current state of the job.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Fulfilled for "FULFILLED"
            /// </summary>
            [EnumMember(Value = "FULFILLED")]
            Fulfilled,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Ready for "READY"
            /// </summary>
            [EnumMember(Value = "READY")]
            Ready,
            
            /// <summary>
            /// Enum Processing for "PROCESSING"
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            Processing,
            
            /// <summary>
            /// Enum Cancelled for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current state of the job.
        /// </summary>
        /// <value>The current state of the job.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecordingJob() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingJob" /> class.
        /// </summary>
        /// <param name="State">The current state of the job. (required).</param>
        /// <param name="RecordingJobsQuery">Original query of the job..</param>
        /// <param name="User">Details of the user created the job.</param>
        public RecordingJob(StateEnum? State = null, RecordingJobsQuery RecordingJobsQuery = null, AddressableEntityRef User = null)
        {
            this.State = State;
            this.RecordingJobsQuery = RecordingJobsQuery;
            this.User = User;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Original query of the job.
        /// </summary>
        /// <value>Original query of the job.</value>
        [DataMember(Name="recordingJobsQuery", EmitDefaultValue=false)]
        public RecordingJobsQuery RecordingJobsQuery { get; set; }
        
        
        
        /// <summary>
        /// Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Total number of conversations affected.
        /// </summary>
        /// <value>Total number of conversations affected.</value>
        [DataMember(Name="totalConversations", EmitDefaultValue=false)]
        public int? TotalConversations { get; private set; }
        
        
        
        /// <summary>
        /// Total number of recordings affected.
        /// </summary>
        /// <value>Total number of recordings affected.</value>
        [DataMember(Name="totalRecordings", EmitDefaultValue=false)]
        public int? TotalRecordings { get; private set; }
        
        
        
        /// <summary>
        /// Total number of recordings that have been skipped.
        /// </summary>
        /// <value>Total number of recordings that have been skipped.</value>
        [DataMember(Name="totalSkippedRecordings", EmitDefaultValue=false)]
        public int? TotalSkippedRecordings { get; private set; }
        
        
        
        /// <summary>
        /// Total number of recordings that the bulk job failed to process.
        /// </summary>
        /// <value>Total number of recordings that the bulk job failed to process.</value>
        [DataMember(Name="totalFailedRecordings", EmitDefaultValue=false)]
        public int? TotalFailedRecordings { get; private set; }
        
        
        
        /// <summary>
        /// Total number of recordings have been processed.
        /// </summary>
        /// <value>Total number of recordings have been processed.</value>
        [DataMember(Name="totalProcessedRecordings", EmitDefaultValue=false)]
        public int? TotalProcessedRecordings { get; private set; }
        
        
        
        /// <summary>
        /// Progress in percentage based on the number of recordings
        /// </summary>
        /// <value>Progress in percentage based on the number of recordings</value>
        [DataMember(Name="percentProgress", EmitDefaultValue=false)]
        public int? PercentProgress { get; private set; }
        
        
        
        /// <summary>
        /// Error occurred during the job execution
        /// </summary>
        /// <value>Error occurred during the job execution</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; private set; }
        
        
        
        /// <summary>
        /// Get IDs of recordings that the bulk job failed for
        /// </summary>
        /// <value>Get IDs of recordings that the bulk job failed for</value>
        [DataMember(Name="failedRecordings", EmitDefaultValue=false)]
        public string FailedRecordings { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Details of the user created the job
        /// </summary>
        /// <value>Details of the user created the job</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingJob {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  RecordingJobsQuery: ").Append(RecordingJobsQuery).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  TotalConversations: ").Append(TotalConversations).Append("\n");
            sb.Append("  TotalRecordings: ").Append(TotalRecordings).Append("\n");
            sb.Append("  TotalSkippedRecordings: ").Append(TotalSkippedRecordings).Append("\n");
            sb.Append("  TotalFailedRecordings: ").Append(TotalFailedRecordings).Append("\n");
            sb.Append("  TotalProcessedRecordings: ").Append(TotalProcessedRecordings).Append("\n");
            sb.Append("  PercentProgress: ").Append(PercentProgress).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  FailedRecordings: ").Append(FailedRecordings).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as RecordingJob);
        }

        /// <summary>
        /// Returns true if RecordingJob instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingJob other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.RecordingJobsQuery == other.RecordingJobsQuery ||
                    this.RecordingJobsQuery != null &&
                    this.RecordingJobsQuery.Equals(other.RecordingJobsQuery)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.TotalConversations == other.TotalConversations ||
                    this.TotalConversations != null &&
                    this.TotalConversations.Equals(other.TotalConversations)
                ) &&
                (
                    this.TotalRecordings == other.TotalRecordings ||
                    this.TotalRecordings != null &&
                    this.TotalRecordings.Equals(other.TotalRecordings)
                ) &&
                (
                    this.TotalSkippedRecordings == other.TotalSkippedRecordings ||
                    this.TotalSkippedRecordings != null &&
                    this.TotalSkippedRecordings.Equals(other.TotalSkippedRecordings)
                ) &&
                (
                    this.TotalFailedRecordings == other.TotalFailedRecordings ||
                    this.TotalFailedRecordings != null &&
                    this.TotalFailedRecordings.Equals(other.TotalFailedRecordings)
                ) &&
                (
                    this.TotalProcessedRecordings == other.TotalProcessedRecordings ||
                    this.TotalProcessedRecordings != null &&
                    this.TotalProcessedRecordings.Equals(other.TotalProcessedRecordings)
                ) &&
                (
                    this.PercentProgress == other.PercentProgress ||
                    this.PercentProgress != null &&
                    this.PercentProgress.Equals(other.PercentProgress)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.FailedRecordings == other.FailedRecordings ||
                    this.FailedRecordings != null &&
                    this.FailedRecordings.Equals(other.FailedRecordings)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.RecordingJobsQuery != null)
                    hash = hash * 59 + this.RecordingJobsQuery.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.TotalConversations != null)
                    hash = hash * 59 + this.TotalConversations.GetHashCode();
                
                if (this.TotalRecordings != null)
                    hash = hash * 59 + this.TotalRecordings.GetHashCode();
                
                if (this.TotalSkippedRecordings != null)
                    hash = hash * 59 + this.TotalSkippedRecordings.GetHashCode();
                
                if (this.TotalFailedRecordings != null)
                    hash = hash * 59 + this.TotalFailedRecordings.GetHashCode();
                
                if (this.TotalProcessedRecordings != null)
                    hash = hash * 59 + this.TotalProcessedRecordings.GetHashCode();
                
                if (this.PercentProgress != null)
                    hash = hash * 59 + this.PercentProgress.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.FailedRecordings != null)
                    hash = hash * 59 + this.FailedRecordings.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                return hash;
            }
        }
    }

}
