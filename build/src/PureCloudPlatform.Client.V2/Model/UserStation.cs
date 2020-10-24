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
    /// UserStation
    /// </summary>
    [DataContract]
    public partial class UserStation :  IEquatable<UserStation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStation" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="AssociatedUser">AssociatedUser.</param>
        /// <param name="AssociatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DefaultUser">DefaultUser.</param>
        /// <param name="ProviderInfo">Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }.</param>
        public UserStation(string Name = null, string Type = null, User AssociatedUser = null, DateTime? AssociatedDate = null, User DefaultUser = null, Dictionary<string, string> ProviderInfo = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.AssociatedUser = AssociatedUser;
            this.AssociatedDate = AssociatedDate;
            this.DefaultUser = DefaultUser;
            this.ProviderInfo = ProviderInfo;
            
        }
        
        
        
        /// <summary>
        /// A globally unique identifier for this station
        /// </summary>
        /// <value>A globally unique identifier for this station</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AssociatedUser
        /// </summary>
        [DataMember(Name="associatedUser", EmitDefaultValue=false)]
        public User AssociatedUser { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="associatedDate", EmitDefaultValue=false)]
        public DateTime? AssociatedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DefaultUser
        /// </summary>
        [DataMember(Name="defaultUser", EmitDefaultValue=false)]
        public User DefaultUser { get; set; }
        
        
        
        /// <summary>
        /// Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }
        /// </summary>
        /// <value>Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }</value>
        [DataMember(Name="providerInfo", EmitDefaultValue=false)]
        public Dictionary<string, string> ProviderInfo { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStation {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AssociatedUser: ").Append(AssociatedUser).Append("\n");
            sb.Append("  AssociatedDate: ").Append(AssociatedDate).Append("\n");
            sb.Append("  DefaultUser: ").Append(DefaultUser).Append("\n");
            sb.Append("  ProviderInfo: ").Append(ProviderInfo).Append("\n");
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
            return this.Equals(obj as UserStation);
        }

        /// <summary>
        /// Returns true if UserStation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStation other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.AssociatedUser == other.AssociatedUser ||
                    this.AssociatedUser != null &&
                    this.AssociatedUser.Equals(other.AssociatedUser)
                ) &&
                (
                    this.AssociatedDate == other.AssociatedDate ||
                    this.AssociatedDate != null &&
                    this.AssociatedDate.Equals(other.AssociatedDate)
                ) &&
                (
                    this.DefaultUser == other.DefaultUser ||
                    this.DefaultUser != null &&
                    this.DefaultUser.Equals(other.DefaultUser)
                ) &&
                (
                    this.ProviderInfo == other.ProviderInfo ||
                    this.ProviderInfo != null &&
                    this.ProviderInfo.SequenceEqual(other.ProviderInfo)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.AssociatedUser != null)
                    hash = hash * 59 + this.AssociatedUser.GetHashCode();
                
                if (this.AssociatedDate != null)
                    hash = hash * 59 + this.AssociatedDate.GetHashCode();
                
                if (this.DefaultUser != null)
                    hash = hash * 59 + this.DefaultUser.GetHashCode();
                
                if (this.ProviderInfo != null)
                    hash = hash * 59 + this.ProviderInfo.GetHashCode();
                
                return hash;
            }
        }
    }

}
