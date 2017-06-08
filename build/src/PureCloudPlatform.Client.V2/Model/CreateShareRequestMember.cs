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
    /// CreateShareRequestMember
    /// </summary>
    [DataContract]
    public partial class CreateShareRequestMember :  IEquatable<CreateShareRequestMember>
    {
        
        
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
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public MemberTypeEnum? MemberType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareRequestMember" /> class.
        /// </summary>
        
        
        /// <param name="MemberType">MemberType.</param>
        
        
        
        /// <param name="Member">Member.</param>
        
        
        public CreateShareRequestMember(MemberTypeEnum? MemberType = null, MemberEntity Member = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MemberType = MemberType;
            
            
            
            
            
            
            
            
this.Member = Member;
            
            
            
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public MemberEntity Member { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateShareRequestMember {\n");
            
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            
            sb.Append("  Member: ").Append(Member).Append("\n");
            
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
            return this.Equals(obj as CreateShareRequestMember);
        }

        /// <summary>
        /// Returns true if CreateShareRequestMember instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateShareRequestMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShareRequestMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MemberType == other.MemberType ||
                    this.MemberType != null &&
                    this.MemberType.Equals(other.MemberType)
                ) &&
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
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
                
                if (this.MemberType != null)
                    hash = hash * 59 + this.MemberType.GetHashCode();
                
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                
                return hash;
            }
        }
    }

}
