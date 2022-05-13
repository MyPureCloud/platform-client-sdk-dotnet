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
    /// LimitChangeRequestDetails
    /// </summary>
    [DataContract]
    public partial class LimitChangeRequestDetails :  IEquatable<LimitChangeRequestDetails>
    {
        /// <summary>
        /// Current status of the limit change request
        /// </summary>
        /// <value>Current status of the limit change request</value>
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
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Implementingchange for "ImplementingChange"
            /// </summary>
            [EnumMember(Value = "ImplementingChange")]
            Implementingchange,
            
            /// <summary>
            /// Enum Changeimplemented for "ChangeImplemented"
            /// </summary>
            [EnumMember(Value = "ChangeImplemented")]
            Changeimplemented,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Rollback for "Rollback"
            /// </summary>
            [EnumMember(Value = "Rollback")]
            Rollback,
            
            /// <summary>
            /// Enum Implementingrollback for "ImplementingRollback"
            /// </summary>
            [EnumMember(Value = "ImplementingRollback")]
            Implementingrollback,
            
            /// <summary>
            /// Enum Rollbackimplemented for "RollbackImplemented"
            /// </summary>
            [EnumMember(Value = "RollbackImplemented")]
            Rollbackimplemented
        }
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RejectReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alternativeexists for "AlternativeExists"
            /// </summary>
            [EnumMember(Value = "AlternativeExists")]
            Alternativeexists,
            
            /// <summary>
            /// Enum Increasenotrequired for "IncreaseNotRequired"
            /// </summary>
            [EnumMember(Value = "IncreaseNotRequired")]
            Increasenotrequired,
            
            /// <summary>
            /// Enum Platformmisuse for "PlatformMisuse"
            /// </summary>
            [EnumMember(Value = "PlatformMisuse")]
            Platformmisuse,
            
            /// <summary>
            /// Enum Platformstability for "PlatformStability"
            /// </summary>
            [EnumMember(Value = "PlatformStability")]
            Platformstability,
            
            /// <summary>
            /// Enum Otherreason for "OtherReason"
            /// </summary>
            [EnumMember(Value = "OtherReason")]
            Otherreason
        }
        /// <summary>
        /// Current status of the limit change request
        /// </summary>
        /// <value>Current status of the limit change request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [DataMember(Name="rejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum? RejectReason { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitChangeRequestDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitChangeRequestDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitChangeRequestDetails" /> class.
        /// </summary>
        /// <param name="Key">Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) (required).</param>
        /// <param name="Namespace">Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) (required).</param>
        /// <param name="RequestedValue">Requested limit value for a given key (required).</param>
        /// <param name="Description">Description of the need for the limit change request (required).</param>
        /// <param name="SupportCaseUrl">The support case url created by Care (required).</param>
        public LimitChangeRequestDetails(string Key = null, string Namespace = null, double? RequestedValue = null, string Description = null, string SupportCaseUrl = null)
        {
            this.Key = Key;
            this.Namespace = Namespace;
            this.RequestedValue = RequestedValue;
            this.Description = Description;
            this.SupportCaseUrl = SupportCaseUrl;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)
        /// </summary>
        /// <value>Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }



        /// <summary>
        /// Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)
        /// </summary>
        /// <value>Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }



        /// <summary>
        /// Requested limit value for a given key
        /// </summary>
        /// <value>Requested limit value for a given key</value>
        [DataMember(Name="requestedValue", EmitDefaultValue=false)]
        public double? RequestedValue { get; set; }



        /// <summary>
        /// Description of the need for the limit change request
        /// </summary>
        /// <value>Description of the need for the limit change request</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The support case url created by Care
        /// </summary>
        /// <value>The support case url created by Care</value>
        [DataMember(Name="supportCaseUrl", EmitDefaultValue=false)]
        public string SupportCaseUrl { get; set; }



        /// <summary>
        /// The user who created the change request
        /// </summary>
        /// <value>The user who created the change request</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; private set; }





        /// <summary>
        /// Current limit value for a given key
        /// </summary>
        /// <value>Current limit value for a given key</value>
        [DataMember(Name="currentValue", EmitDefaultValue=false)]
        public double? CurrentValue { get; private set; }



        /// <summary>
        /// The date of the limit change request creation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the limit change request creation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// List of statuses that a limit change request has gone through
        /// </summary>
        /// <value>List of statuses that a limit change request has gone through</value>
        [DataMember(Name="statusHistory", EmitDefaultValue=false)]
        public List<StatusChange> StatusHistory { get; private set; }



        /// <summary>
        /// The date of the limit change request completion (ChangeImplemented, Rejected, or RollbackImplemented. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the limit change request completion (ChangeImplemented, Rejected, or RollbackImplemented. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; private set; }



        /// <summary>
        /// The user who last updated the status of the limit change request
        /// </summary>
        /// <value>The user who last updated the status of the limit change request</value>
        [DataMember(Name="lastChangedBy", EmitDefaultValue=false)]
        public string LastChangedBy { get; private set; }





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
            sb.Append("class LimitChangeRequestDetails {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  RequestedValue: ").Append(RequestedValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SupportCaseUrl: ").Append(SupportCaseUrl).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  StatusHistory: ").Append(StatusHistory).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  LastChangedBy: ").Append(LastChangedBy).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
            return this.Equals(obj as LimitChangeRequestDetails);
        }

        /// <summary>
        /// Returns true if LimitChangeRequestDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitChangeRequestDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitChangeRequestDetails other)
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
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.RequestedValue == other.RequestedValue ||
                    this.RequestedValue != null &&
                    this.RequestedValue.Equals(other.RequestedValue)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.SupportCaseUrl == other.SupportCaseUrl ||
                    this.SupportCaseUrl != null &&
                    this.SupportCaseUrl.Equals(other.SupportCaseUrl)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.CurrentValue == other.CurrentValue ||
                    this.CurrentValue != null &&
                    this.CurrentValue.Equals(other.CurrentValue)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.StatusHistory == other.StatusHistory ||
                    this.StatusHistory != null &&
                    this.StatusHistory.SequenceEqual(other.StatusHistory)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.LastChangedBy == other.LastChangedBy ||
                    this.LastChangedBy != null &&
                    this.LastChangedBy.Equals(other.LastChangedBy)
                ) &&
                (
                    this.RejectReason == other.RejectReason ||
                    this.RejectReason != null &&
                    this.RejectReason.Equals(other.RejectReason)
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

                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.RequestedValue != null)
                    hash = hash * 59 + this.RequestedValue.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.SupportCaseUrl != null)
                    hash = hash * 59 + this.SupportCaseUrl.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.CurrentValue != null)
                    hash = hash * 59 + this.CurrentValue.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.StatusHistory != null)
                    hash = hash * 59 + this.StatusHistory.GetHashCode();

                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();

                if (this.LastChangedBy != null)
                    hash = hash * 59 + this.LastChangedBy.GetHashCode();

                if (this.RejectReason != null)
                    hash = hash * 59 + this.RejectReason.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
