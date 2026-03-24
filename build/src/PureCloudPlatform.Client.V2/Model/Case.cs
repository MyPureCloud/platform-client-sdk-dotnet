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
    /// Case
    /// </summary>
    [DataContract]
    public partial class Case :  IEquatable<Case>
    {
        /// <summary>
        /// The status of the Case.
        /// </summary>
        /// <value>The status of the Case.</value>
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
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Terminating for "Terminating"
            /// </summary>
            [EnumMember(Value = "Terminating")]
            Terminating,
            
            /// <summary>
            /// Enum Terminated for "Terminated"
            /// </summary>
            [EnumMember(Value = "Terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// The priority of the Case.
        /// </summary>
        /// <value>The priority of the Case.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PriorityEnum
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
            /// Enum Urgent for "Urgent"
            /// </summary>
            [EnumMember(Value = "Urgent")]
            Urgent,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low
        }
        /// <summary>
        /// The creation status of the Case
        /// </summary>
        /// <value>The creation status of the Case</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CreationStatusEnum
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
        /// The status of the Case.
        /// </summary>
        /// <value>The status of the Case.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The priority of the Case.
        /// </summary>
        /// <value>The priority of the Case.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// The creation status of the Case
        /// </summary>
        /// <value>The creation status of the Case</value>
        [DataMember(Name="creationStatus", EmitDefaultValue=false)]
        public CreationStatusEnum? CreationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Case" /> class.
        /// </summary>
        /// <param name="Name">The name of the Case..</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Version">The version of the Case..</param>
        /// <param name="Reference">The reference identifier of the Case..</param>
        /// <param name="Caseplan">The Caseplan the case was created from..</param>
        /// <param name="Summary">Overview information for the Case..</param>
        /// <param name="Owner">The owner of the Case..</param>
        /// <param name="Status">The status of the Case..</param>
        /// <param name="Priority">The priority of the Case..</param>
        /// <param name="DateDue">The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateStarted">The start time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateClosed">The completion time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateCreated">The date the Case was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The date the Case was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The id of the User who modified the Case..</param>
        /// <param name="ExternalContact">The External Contact associated with the Case..</param>
        /// <param name="CustomerIntent">The customer intent for the Case..</param>
        /// <param name="CreationStatus">The creation status of the Case.</param>
        /// <param name="TtlSeconds">The time-to-live in seconds for the lifetime of the Case..</param>
        public Case(string Name = null, StarrableDivision Division = null, int? Version = null, string Reference = null, CaseplanReference Caseplan = null, string Summary = null, UserReference Owner = null, StatusEnum? Status = null, PriorityEnum? Priority = null, DateTime? DateDue = null, DateTime? DateStarted = null, DateTime? DateClosed = null, DateTime? DateCreated = null, DateTime? DateModified = null, UserReference ModifiedBy = null, CaseExternalContactReference ExternalContact = null, CustomerIntentReference CustomerIntent = null, CreationStatusEnum? CreationStatus = null, int? TtlSeconds = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Version = Version;
            this.Reference = Reference;
            this.Caseplan = Caseplan;
            this.Summary = Summary;
            this.Owner = Owner;
            this.Status = Status;
            this.Priority = Priority;
            this.DateDue = DateDue;
            this.DateStarted = DateStarted;
            this.DateClosed = DateClosed;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.ExternalContact = ExternalContact;
            this.CustomerIntent = CustomerIntent;
            this.CreationStatus = CreationStatus;
            this.TtlSeconds = TtlSeconds;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Case.
        /// </summary>
        /// <value>The name of the Case.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public StarrableDivision Division { get; set; }



        /// <summary>
        /// The version of the Case.
        /// </summary>
        /// <value>The version of the Case.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The reference identifier of the Case.
        /// </summary>
        /// <value>The reference identifier of the Case.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }



        /// <summary>
        /// The Caseplan the case was created from.
        /// </summary>
        /// <value>The Caseplan the case was created from.</value>
        [DataMember(Name="caseplan", EmitDefaultValue=false)]
        public CaseplanReference Caseplan { get; set; }



        /// <summary>
        /// Overview information for the Case.
        /// </summary>
        /// <value>Overview information for the Case.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }



        /// <summary>
        /// The owner of the Case.
        /// </summary>
        /// <value>The owner of the Case.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserReference Owner { get; set; }







        /// <summary>
        /// The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The due date of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDue", EmitDefaultValue=false)]
        public DateTime? DateDue { get; set; }



        /// <summary>
        /// The start time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; set; }



        /// <summary>
        /// The completion time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The completion time of the Case. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateClosed", EmitDefaultValue=false)]
        public DateTime? DateClosed { get; set; }



        /// <summary>
        /// The date the Case was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the Case was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The date the Case was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the Case was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The id of the User who modified the Case.
        /// </summary>
        /// <value>The id of the User who modified the Case.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }



        /// <summary>
        /// The External Contact associated with the Case.
        /// </summary>
        /// <value>The External Contact associated with the Case.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public CaseExternalContactReference ExternalContact { get; set; }



        /// <summary>
        /// The customer intent for the Case.
        /// </summary>
        /// <value>The customer intent for the Case.</value>
        [DataMember(Name="customerIntent", EmitDefaultValue=false)]
        public CustomerIntentReference CustomerIntent { get; set; }





        /// <summary>
        /// The time-to-live in seconds for the lifetime of the Case.
        /// </summary>
        /// <value>The time-to-live in seconds for the lifetime of the Case.</value>
        [DataMember(Name="ttlSeconds", EmitDefaultValue=false)]
        public int? TtlSeconds { get; set; }



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
            sb.Append("class Case {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Caseplan: ").Append(Caseplan).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DateDue: ").Append(DateDue).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  CustomerIntent: ").Append(CustomerIntent).Append("\n");
            sb.Append("  CreationStatus: ").Append(CreationStatus).Append("\n");
            sb.Append("  TtlSeconds: ").Append(TtlSeconds).Append("\n");
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
            return this.Equals(obj as Case);
        }

        /// <summary>
        /// Returns true if Case instances are equal
        /// </summary>
        /// <param name="other">Instance of Case to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Case other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) &&
                (
                    this.Caseplan == other.Caseplan ||
                    this.Caseplan != null &&
                    this.Caseplan.Equals(other.Caseplan)
                ) &&
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.DateDue == other.DateDue ||
                    this.DateDue != null &&
                    this.DateDue.Equals(other.DateDue)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.DateClosed == other.DateClosed ||
                    this.DateClosed != null &&
                    this.DateClosed.Equals(other.DateClosed)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.CustomerIntent == other.CustomerIntent ||
                    this.CustomerIntent != null &&
                    this.CustomerIntent.Equals(other.CustomerIntent)
                ) &&
                (
                    this.CreationStatus == other.CreationStatus ||
                    this.CreationStatus != null &&
                    this.CreationStatus.Equals(other.CreationStatus)
                ) &&
                (
                    this.TtlSeconds == other.TtlSeconds ||
                    this.TtlSeconds != null &&
                    this.TtlSeconds.Equals(other.TtlSeconds)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();

                if (this.Caseplan != null)
                    hash = hash * 59 + this.Caseplan.GetHashCode();

                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();

                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.DateDue != null)
                    hash = hash * 59 + this.DateDue.GetHashCode();

                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();

                if (this.DateClosed != null)
                    hash = hash * 59 + this.DateClosed.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.CustomerIntent != null)
                    hash = hash * 59 + this.CustomerIntent.GetHashCode();

                if (this.CreationStatus != null)
                    hash = hash * 59 + this.CreationStatus.GetHashCode();

                if (this.TtlSeconds != null)
                    hash = hash * 59 + this.TtlSeconds.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
