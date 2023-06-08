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
    /// SegmentAssignment
    /// </summary>
    [DataContract]
    public partial class SegmentAssignment :  IEquatable<SegmentAssignment>
    {
        /// <summary>
        /// State of the segment assignment.
        /// </summary>
        /// <value>State of the segment assignment.</value>
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
            /// Enum Assigned for "Assigned"
            /// </summary>
            [EnumMember(Value = "Assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Unassigned for "Unassigned"
            /// </summary>
            [EnumMember(Value = "Unassigned")]
            Unassigned
        }
        /// <summary>
        /// State of the segment assignment.
        /// </summary>
        /// <value>State of the segment assignment.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignment" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the segment assignment..</param>
        /// <param name="State">State of the segment assignment..</param>
        /// <param name="DateAssigned">Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateUnassigned">Date when the segment was unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">Date when the segment assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Segment">The segment the assignment is for..</param>
        /// <param name="CustomerId">ID of the customer to which the segment is assigned..</param>
        /// <param name="CustomerIdType">Type of customer ID (e.g. cookie, email, phone)..</param>
        /// <param name="Session">For session-scoped segments, the session for which the segment was assigned..</param>
        public SegmentAssignment(string Id = null, StateEnum? State = null, DateTime? DateAssigned = null, DateTime? DateUnassigned = null, DateTime? DateModified = null, SegmentAssignmentSegment Segment = null, string CustomerId = null, string CustomerIdType = null, SegmentAssignmentSession Session = null)
        {
            this.Id = Id;
            this.State = State;
            this.DateAssigned = DateAssigned;
            this.DateUnassigned = DateUnassigned;
            this.DateModified = DateModified;
            this.Segment = Segment;
            this.CustomerId = CustomerId;
            this.CustomerIdType = CustomerIdType;
            this.Session = Session;
            
        }
        


        /// <summary>
        /// Unique identifier for the segment assignment.
        /// </summary>
        /// <value>Unique identifier for the segment assignment.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssigned", EmitDefaultValue=false)]
        public DateTime? DateAssigned { get; set; }



        /// <summary>
        /// Date when the segment was unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the segment was unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateUnassigned", EmitDefaultValue=false)]
        public DateTime? DateUnassigned { get; set; }



        /// <summary>
        /// Date when the segment assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the segment assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The segment the assignment is for.
        /// </summary>
        /// <value>The segment the assignment is for.</value>
        [DataMember(Name="segment", EmitDefaultValue=false)]
        public SegmentAssignmentSegment Segment { get; set; }



        /// <summary>
        /// ID of the customer to which the segment is assigned.
        /// </summary>
        /// <value>ID of the customer to which the segment is assigned.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Type of customer ID (e.g. cookie, email, phone).
        /// </summary>
        /// <value>Type of customer ID (e.g. cookie, email, phone).</value>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }



        /// <summary>
        /// For session-scoped segments, the session for which the segment was assigned.
        /// </summary>
        /// <value>For session-scoped segments, the session for which the segment was assigned.</value>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public SegmentAssignmentSession Session { get; set; }



        /// <summary>
        /// External contact of the customer to which the segment is assigned.
        /// </summary>
        /// <value>External contact of the customer to which the segment is assigned.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public AddressableEntityRef ExternalContact { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentAssignment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
            sb.Append("  DateUnassigned: ").Append(DateUnassigned).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
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
            return this.Equals(obj as SegmentAssignment);
        }

        /// <summary>
        /// Returns true if SegmentAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentAssignment other)
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
                    this.DateAssigned == other.DateAssigned ||
                    this.DateAssigned != null &&
                    this.DateAssigned.Equals(other.DateAssigned)
                ) &&
                (
                    this.DateUnassigned == other.DateUnassigned ||
                    this.DateUnassigned != null &&
                    this.DateUnassigned.Equals(other.DateUnassigned)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Segment == other.Segment ||
                    this.Segment != null &&
                    this.Segment.Equals(other.Segment)
                ) &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.CustomerIdType == other.CustomerIdType ||
                    this.CustomerIdType != null &&
                    this.CustomerIdType.Equals(other.CustomerIdType)
                ) &&
                (
                    this.Session == other.Session ||
                    this.Session != null &&
                    this.Session.Equals(other.Session)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
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

                if (this.DateAssigned != null)
                    hash = hash * 59 + this.DateAssigned.GetHashCode();

                if (this.DateUnassigned != null)
                    hash = hash * 59 + this.DateUnassigned.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Segment != null)
                    hash = hash * 59 + this.Segment.GetHashCode();

                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                return hash;
            }
        }
    }

}
