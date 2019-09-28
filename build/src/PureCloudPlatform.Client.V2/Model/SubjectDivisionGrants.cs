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
    /// SubjectDivisionGrants
    /// </summary>
    [DataContract]
    public partial class SubjectDivisionGrants :  IEquatable<SubjectDivisionGrants>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum PcUser for "PC_USER"
            /// </summary>
            [EnumMember(Value = "PC_USER")]
            PcUser,
            
            /// <summary>
            /// Enum PcGroup for "PC_GROUP"
            /// </summary>
            [EnumMember(Value = "PC_GROUP")]
            PcGroup,
            
            /// <summary>
            /// Enum PcOauthClient for "PC_OAUTH_CLIENT"
            /// </summary>
            [EnumMember(Value = "PC_OAUTH_CLIENT")]
            PcOauthClient,
            
            /// <summary>
            /// Enum PcTrusteeUser for "PC_TRUSTEE_USER"
            /// </summary>
            [EnumMember(Value = "PC_TRUSTEE_USER")]
            PcTrusteeUser,
            
            /// <summary>
            /// Enum PcTrusteeGroup for "PC_TRUSTEE_GROUP"
            /// </summary>
            [EnumMember(Value = "PC_TRUSTEE_GROUP")]
            PcTrusteeGroup,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectDivisionGrants" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Divisions">Divisions.</param>
        /// <param name="Type">Type.</param>
        public SubjectDivisionGrants(string Name = null, List<Division> Divisions = null, TypeEnum? Type = null)
        {
            this.Name = Name;
            this.Divisions = Divisions;
            this.Type = Type;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Divisions
        /// </summary>
        [DataMember(Name="divisions", EmitDefaultValue=false)]
        public List<Division> Divisions { get; set; }
        
        
        
        
        
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
            sb.Append("class SubjectDivisionGrants {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as SubjectDivisionGrants);
        }

        /// <summary>
        /// Returns true if SubjectDivisionGrants instances are equal
        /// </summary>
        /// <param name="other">Instance of SubjectDivisionGrants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectDivisionGrants other)
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
                    this.Divisions == other.Divisions ||
                    this.Divisions != null &&
                    this.Divisions.SequenceEqual(other.Divisions)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Divisions != null)
                    hash = hash * 59 + this.Divisions.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
