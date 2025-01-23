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
    /// BulkJob
    /// </summary>
    [DataContract]
    public partial class BulkJob :  IEquatable<BulkJob>
    {
        /// <summary>
        /// The bulk job state.
        /// </summary>
        /// <value>The bulk job state.</value>
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
            /// Enum Idle for "Idle"
            /// </summary>
            [EnumMember(Value = "Idle")]
            Idle,
            
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
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Terminated for "Terminated"
            /// </summary>
            [EnumMember(Value = "Terminated")]
            Terminated
        }
        /// <summary>
        /// The bulk job action. This determines what the bulk job does, for example, terminate workitems.
        /// </summary>
        /// <value>The bulk job action. This determines what the bulk job does, for example, terminate workitems.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Terminateworkitems for "TerminateWorkitems"
            /// </summary>
            [EnumMember(Value = "TerminateWorkitems")]
            Terminateworkitems,
            
            /// <summary>
            /// Enum Addworkitems for "AddWorkitems"
            /// </summary>
            [EnumMember(Value = "AddWorkitems")]
            Addworkitems
        }
        /// <summary>
        /// The bulk job state.
        /// </summary>
        /// <value>The bulk job state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The bulk job action. This determines what the bulk job does, for example, terminate workitems.
        /// </summary>
        /// <value>The bulk job action. This determines what the bulk job does, for example, terminate workitems.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkJob" /> class.
        /// </summary>
        /// <param name="State">The bulk job state..</param>
        /// <param name="Action">The bulk job action. This determines what the bulk job does, for example, terminate workitems..</param>
        /// <param name="TotalCount">Total count of items to be processed in the bulk job..</param>
        /// <param name="SuccessfulCount">Count of successfully processed items in the bulk job..</param>
        /// <param name="FailedCount">Count of failed processed items in the bulk job..</param>
        /// <param name="DateStarted">The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateFinished">The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public BulkJob(StateEnum? State = null, ActionEnum? Action = null, int? TotalCount = null, int? SuccessfulCount = null, int? FailedCount = null, DateTime? DateStarted = null, DateTime? DateFinished = null, DateTime? DateModified = null)
        {
            this.State = State;
            this.Action = Action;
            this.TotalCount = TotalCount;
            this.SuccessfulCount = SuccessfulCount;
            this.FailedCount = FailedCount;
            this.DateStarted = DateStarted;
            this.DateFinished = DateFinished;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }







        /// <summary>
        /// Total count of items to be processed in the bulk job.
        /// </summary>
        /// <value>Total count of items to be processed in the bulk job.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Count of successfully processed items in the bulk job.
        /// </summary>
        /// <value>Count of successfully processed items in the bulk job.</value>
        [DataMember(Name="successfulCount", EmitDefaultValue=false)]
        public int? SuccessfulCount { get; set; }



        /// <summary>
        /// Count of failed processed items in the bulk job.
        /// </summary>
        /// <value>Count of failed processed items in the bulk job.</value>
        [DataMember(Name="failedCount", EmitDefaultValue=false)]
        public int? FailedCount { get; set; }



        /// <summary>
        /// The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The bulk job start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; set; }



        /// <summary>
        /// The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The bulk job finished date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateFinished", EmitDefaultValue=false)]
        public DateTime? DateFinished { get; set; }



        /// <summary>
        /// The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The bulk job modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



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
            sb.Append("class BulkJob {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  SuccessfulCount: ").Append(SuccessfulCount).Append("\n");
            sb.Append("  FailedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  DateFinished: ").Append(DateFinished).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as BulkJob);
        }

        /// <summary>
        /// Returns true if BulkJob instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkJob other)
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
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) &&
                (
                    this.SuccessfulCount == other.SuccessfulCount ||
                    this.SuccessfulCount != null &&
                    this.SuccessfulCount.Equals(other.SuccessfulCount)
                ) &&
                (
                    this.FailedCount == other.FailedCount ||
                    this.FailedCount != null &&
                    this.FailedCount.Equals(other.FailedCount)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.DateFinished == other.DateFinished ||
                    this.DateFinished != null &&
                    this.DateFinished.Equals(other.DateFinished)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();

                if (this.SuccessfulCount != null)
                    hash = hash * 59 + this.SuccessfulCount.GetHashCode();

                if (this.FailedCount != null)
                    hash = hash * 59 + this.FailedCount.GetHashCode();

                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();

                if (this.DateFinished != null)
                    hash = hash * 59 + this.DateFinished.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
