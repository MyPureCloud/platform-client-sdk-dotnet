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
    /// QueueMember
    /// </summary>
    [DataContract]
    public partial class QueueMember :  IEquatable<QueueMember>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMember" /> class.
        /// </summary>
        /// <param name="Id">The queue member&#39;s id..</param>
        /// <param name="Name">Name.</param>
        /// <param name="User">User.</param>
        /// <param name="RingNumber">RingNumber.</param>
        /// <param name="Joined">Joined.</param>
        /// <param name="MemberBy">MemberBy.</param>
        /// <param name="RoutingStatus">RoutingStatus.</param>
        public QueueMember(string Id = null, string Name = null, User User = null, int? RingNumber = null, bool? Joined = null, string MemberBy = null, RoutingStatus RoutingStatus = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.User = User;
            this.RingNumber = RingNumber;
            this.Joined = Joined;
            this.MemberBy = MemberBy;
            this.RoutingStatus = RoutingStatus;
        }
        
        /// <summary>
        /// The queue member&#39;s id.
        /// </summary>
        /// <value>The queue member&#39;s id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Gets or Sets RingNumber
        /// </summary>
        [DataMember(Name="ringNumber", EmitDefaultValue=false)]
        public int? RingNumber { get; set; }
        /// <summary>
        /// Gets or Sets Joined
        /// </summary>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public bool? Joined { get; set; }
        /// <summary>
        /// Gets or Sets MemberBy
        /// </summary>
        [DataMember(Name="memberBy", EmitDefaultValue=false)]
        public string MemberBy { get; set; }
        /// <summary>
        /// Gets or Sets RoutingStatus
        /// </summary>
        [DataMember(Name="routingStatus", EmitDefaultValue=false)]
        public RoutingStatus RoutingStatus { get; set; }
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
            sb.Append("class QueueMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  RingNumber: ").Append(RingNumber).Append("\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
            sb.Append("  MemberBy: ").Append(MemberBy).Append("\n");
            sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
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
            return this.Equals(obj as QueueMember);
        }

        /// <summary>
        /// Returns true if QueueMember instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMember other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.RingNumber == other.RingNumber ||
                    this.RingNumber != null &&
                    this.RingNumber.Equals(other.RingNumber)
                ) &&
                (
                    this.Joined == other.Joined ||
                    this.Joined != null &&
                    this.Joined.Equals(other.Joined)
                ) &&
                (
                    this.MemberBy == other.MemberBy ||
                    this.MemberBy != null &&
                    this.MemberBy.Equals(other.MemberBy)
                ) &&
                (
                    this.RoutingStatus == other.RoutingStatus ||
                    this.RoutingStatus != null &&
                    this.RoutingStatus.Equals(other.RoutingStatus)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.RingNumber != null)
                    hash = hash * 59 + this.RingNumber.GetHashCode();
                if (this.Joined != null)
                    hash = hash * 59 + this.Joined.GetHashCode();
                if (this.MemberBy != null)
                    hash = hash * 59 + this.MemberBy.GetHashCode();
                if (this.RoutingStatus != null)
                    hash = hash * 59 + this.RoutingStatus.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
