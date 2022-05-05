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
    /// MemberGroup
    /// </summary>
    [DataContract]
    public partial class MemberGroup :  IEquatable<MemberGroup>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The group type
        /// </summary>
        /// <value>The group type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Team for "TEAM"
            /// </summary>
            [EnumMember(Value = "TEAM")]
            Team,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum Skillgroup for "SKILLGROUP"
            /// </summary>
            [EnumMember(Value = "SKILLGROUP")]
            Skillgroup
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The group type
        /// </summary>
        /// <value>The group type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberGroup" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">Name.</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Type">The group type.</param>
        public MemberGroup(string Id = null, string Name = null, WritableDivision Division = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Division = Division;
            this.Type = Type;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }
        
        
        
        
        
        /// <summary>
        /// The number of members in this group
        /// </summary>
        /// <value>The number of members in this group</value>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }
        
        
        
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
            sb.Append("class MemberGroup {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
            return this.Equals(obj as MemberGroup);
        }

        /// <summary>
        /// Returns true if MemberGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of MemberGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberGroup other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
