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
    /// AsyncQueryStatus
    /// </summary>
    [DataContract]
    public partial class AsyncQueryStatus :  IEquatable<AsyncQueryStatus>
    {
        
        
        /// <summary>
        /// The current state of the asynchronous query
        /// </summary>
        /// <value>The current state of the asynchronous query</value>
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
            /// Enum Queued for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            Queued,
            
            /// <summary>
            /// Enum Pending for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            Pending,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Cancelled for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            
            /// <summary>
            /// Enum Fulfilled for "FULFILLED"
            /// </summary>
            [EnumMember(Value = "FULFILLED")]
            Fulfilled,
            
            /// <summary>
            /// Enum Expired for "EXPIRED"
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            Expired
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The current state of the asynchronous query
        /// </summary>
        /// <value>The current state of the asynchronous query</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncQueryStatus" /> class.
        /// </summary>
        /// <param name="State">The current state of the asynchronous query.</param>
        /// <param name="ErrorMessage">The error associated with the current query, if the state is FAILED.</param>
        /// <param name="ExpirationDate">The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="SubmissionDate">The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CompletionDate">The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public AsyncQueryStatus(StateEnum? State = null, string ErrorMessage = null, DateTime? ExpirationDate = null, DateTime? SubmissionDate = null, DateTime? CompletionDate = null)
        {
            this.State = State;
            this.ErrorMessage = ErrorMessage;
            this.ExpirationDate = ExpirationDate;
            this.SubmissionDate = SubmissionDate;
            this.CompletionDate = CompletionDate;
            
        }
        
        
        
        
        
        /// <summary>
        /// The error associated with the current query, if the state is FAILED
        /// </summary>
        /// <value>The error associated with the current query, if the state is FAILED</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        
        
        
        /// <summary>
        /// The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }
        
        
        
        /// <summary>
        /// The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="submissionDate", EmitDefaultValue=false)]
        public DateTime? SubmissionDate { get; set; }
        
        
        
        /// <summary>
        /// The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="completionDate", EmitDefaultValue=false)]
        public DateTime? CompletionDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncQueryStatus {\n");
            
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  SubmissionDate: ").Append(SubmissionDate).Append("\n");
            sb.Append("  CompletionDate: ").Append(CompletionDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AsyncQueryStatus);
        }

        /// <summary>
        /// Returns true if AsyncQueryStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncQueryStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncQueryStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) &&
                (
                    this.SubmissionDate == other.SubmissionDate ||
                    this.SubmissionDate != null &&
                    this.SubmissionDate.Equals(other.SubmissionDate)
                ) &&
                (
                    this.CompletionDate == other.CompletionDate ||
                    this.CompletionDate != null &&
                    this.CompletionDate.Equals(other.CompletionDate)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                
                if (this.SubmissionDate != null)
                    hash = hash * 59 + this.SubmissionDate.GetHashCode();
                
                if (this.CompletionDate != null)
                    hash = hash * 59 + this.CompletionDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
