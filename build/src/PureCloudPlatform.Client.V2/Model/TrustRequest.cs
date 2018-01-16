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
    /// TrustRequest
    /// </summary>
    [DataContract]
    public partial class TrustRequest :  IEquatable<TrustRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustRequest" /> class.
        /// </summary>
        
        
        
        
        /// <param name="CreatedBy">User who created this request..</param>
        
        
        
        
        
        /// <param name="Trustee">Trustee organization who generated this request. (required).</param>
        
        
        
        /// <param name="Users">The list of trustee users that are requesting access..</param>
        
        
        
        /// <param name="Groups">The list of trustee groups that are requesting access..</param>
        
        
        
        
        public TrustRequest(OrgUser CreatedBy = null, Organization Trustee = null, List<OrgUser> Users = null, List<TrustGroup> Groups = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "Trustee" is required (not null)
            if (Trustee == null)
            {
                throw new InvalidDataException("Trustee is a required property for TrustRequest and cannot be null");
            }
            else
            {
                this.Trustee = Trustee;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.CreatedBy = CreatedBy;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Users = Users;
            
            
            
            
            
            
            
            
this.Groups = Groups;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// User who created this request.
        /// </summary>
        /// <value>User who created this request.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public OrgUser CreatedBy { get; set; }
        
        
        
        /// <summary>
        /// Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Trustee organization who generated this request.
        /// </summary>
        /// <value>Trustee organization who generated this request.</value>
        [DataMember(Name="trustee", EmitDefaultValue=false)]
        public Organization Trustee { get; set; }
        
        
        
        /// <summary>
        /// The list of trustee users that are requesting access.
        /// </summary>
        /// <value>The list of trustee users that are requesting access.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<OrgUser> Users { get; set; }
        
        
        
        /// <summary>
        /// The list of trustee groups that are requesting access.
        /// </summary>
        /// <value>The list of trustee groups that are requesting access.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<TrustGroup> Groups { get; set; }
        
        
        
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
            sb.Append("class TrustRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  Trustee: ").Append(Trustee).Append("\n");
            
            sb.Append("  Users: ").Append(Users).Append("\n");
            
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            
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
            return this.Equals(obj as TrustRequest);
        }

        /// <summary>
        /// Returns true if TrustRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustRequest other)
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.Trustee == other.Trustee ||
                    this.Trustee != null &&
                    this.Trustee.Equals(other.Trustee)
                ) &&
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
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
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.Trustee != null)
                    hash = hash * 59 + this.Trustee.GetHashCode();
                
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
