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
    /// OutboundFaxStatus
    /// </summary>
    [DataContract]
    public partial class OutboundFaxStatus :  IEquatable<OutboundFaxStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundFaxStatus" /> class.
        /// </summary>
        /// <param name="InitiatingUser">The user who sent the fax..</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AuditTransactionId">AuditTransactionId.</param>
        /// <param name="ExpirationTime">ExpirationTime.</param>
        /// <param name="StatusCode">Lifecycle status of the outbound fax send (e.g. UPLOADING, TRANSMITTING, COMPLETE, TERMINATED)..</param>
        /// <param name="Result">Transmission result of the fax. Does NOT indicate successful arrival to a workspace&#39;s inbox..</param>
        public OutboundFaxStatus(AddressableEntityRef InitiatingUser = null, DateTime? DateCreated = null, string AuditTransactionId = null, long? ExpirationTime = null, string StatusCode = null, string Result = null)
        {
            this.InitiatingUser = InitiatingUser;
            this.DateCreated = DateCreated;
            this.AuditTransactionId = AuditTransactionId;
            this.ExpirationTime = ExpirationTime;
            this.StatusCode = StatusCode;
            this.Result = Result;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The user who sent the fax.
        /// </summary>
        /// <value>The user who sent the fax.</value>
        [DataMember(Name="initiatingUser", EmitDefaultValue=false)]
        public AddressableEntityRef InitiatingUser { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets AuditTransactionId
        /// </summary>
        [DataMember(Name="auditTransactionId", EmitDefaultValue=false)]
        public string AuditTransactionId { get; set; }



        /// <summary>
        /// Gets or Sets ExpirationTime
        /// </summary>
        [DataMember(Name="expirationTime", EmitDefaultValue=false)]
        public long? ExpirationTime { get; set; }



        /// <summary>
        /// Lifecycle status of the outbound fax send (e.g. UPLOADING, TRANSMITTING, COMPLETE, TERMINATED).
        /// </summary>
        /// <value>Lifecycle status of the outbound fax send (e.g. UPLOADING, TRANSMITTING, COMPLETE, TERMINATED).</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public string StatusCode { get; set; }



        /// <summary>
        /// Transmission result of the fax. Does NOT indicate successful arrival to a workspace&#39;s inbox.
        /// </summary>
        /// <value>Transmission result of the fax. Does NOT indicate successful arrival to a workspace&#39;s inbox.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }



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
            sb.Append("class OutboundFaxStatus {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  AuditTransactionId: ").Append(AuditTransactionId).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as OutboundFaxStatus);
        }

        /// <summary>
        /// Returns true if OutboundFaxStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundFaxStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundFaxStatus other)
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
                    this.InitiatingUser == other.InitiatingUser ||
                    this.InitiatingUser != null &&
                    this.InitiatingUser.Equals(other.InitiatingUser)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.AuditTransactionId == other.AuditTransactionId ||
                    this.AuditTransactionId != null &&
                    this.AuditTransactionId.Equals(other.AuditTransactionId)
                ) &&
                (
                    this.ExpirationTime == other.ExpirationTime ||
                    this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(other.ExpirationTime)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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

                if (this.InitiatingUser != null)
                    hash = hash * 59 + this.InitiatingUser.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.AuditTransactionId != null)
                    hash = hash * 59 + this.AuditTransactionId.GetHashCode();

                if (this.ExpirationTime != null)
                    hash = hash * 59 + this.ExpirationTime.GetHashCode();

                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
