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
    /// CreateShareRequest
    /// </summary>
    [DataContract]
    public partial class CreateShareRequest :  IEquatable<CreateShareRequest>
    {
        
        
        /// <summary>
        /// The share entity type
        /// </summary>
        /// <value>The share entity type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SharedEntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Document for "DOCUMENT"
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            Document
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MemberTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum Public for "PUBLIC"
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            Public
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The share entity type
        /// </summary>
        /// <value>The share entity type</value>
        [DataMember(Name="sharedEntityType", EmitDefaultValue=false)]
        public SharedEntityTypeEnum? SharedEntityType { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public MemberTypeEnum? MemberType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateShareRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareRequest" /> class.
        /// </summary>
        /// <param name="SharedEntityType">The share entity type (required).</param>
        /// <param name="SharedEntity">The entity that will be shared (required).</param>
        /// <param name="MemberType">MemberType.</param>
        /// <param name="Member">The member that will have access to this share. Only required if a list of members is not provided..</param>
        /// <param name="Members">Members.</param>
        public CreateShareRequest(SharedEntityTypeEnum? SharedEntityType = null, SharedEntity SharedEntity = null, MemberTypeEnum? MemberType = null, SharedEntity Member = null, List<CreateShareRequestMember> Members = null)
        {
            this.SharedEntityType = SharedEntityType;
            this.SharedEntity = SharedEntity;
            this.MemberType = MemberType;
            this.Member = Member;
            this.Members = Members;
            
        }
        
        
        
        
        
        /// <summary>
        /// The entity that will be shared
        /// </summary>
        /// <value>The entity that will be shared</value>
        [DataMember(Name="sharedEntity", EmitDefaultValue=false)]
        public SharedEntity SharedEntity { get; set; }
        
        
        
        
        
        /// <summary>
        /// The member that will have access to this share. Only required if a list of members is not provided.
        /// </summary>
        /// <value>The member that will have access to this share. Only required if a list of members is not provided.</value>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public SharedEntity Member { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<CreateShareRequestMember> Members { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateShareRequest {\n");
            
            sb.Append("  SharedEntityType: ").Append(SharedEntityType).Append("\n");
            sb.Append("  SharedEntity: ").Append(SharedEntity).Append("\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(obj as CreateShareRequest);
        }

        /// <summary>
        /// Returns true if CreateShareRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateShareRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShareRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SharedEntityType == other.SharedEntityType ||
                    this.SharedEntityType != null &&
                    this.SharedEntityType.Equals(other.SharedEntityType)
                ) &&
                (
                    this.SharedEntity == other.SharedEntity ||
                    this.SharedEntity != null &&
                    this.SharedEntity.Equals(other.SharedEntity)
                ) &&
                (
                    this.MemberType == other.MemberType ||
                    this.MemberType != null &&
                    this.MemberType.Equals(other.MemberType)
                ) &&
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
                ) &&
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
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
                
                if (this.SharedEntityType != null)
                    hash = hash * 59 + this.SharedEntityType.GetHashCode();
                
                if (this.SharedEntity != null)
                    hash = hash * 59 + this.SharedEntity.GetHashCode();
                
                if (this.MemberType != null)
                    hash = hash * 59 + this.MemberType.GetHashCode();
                
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                
                return hash;
            }
        }
    }

}
