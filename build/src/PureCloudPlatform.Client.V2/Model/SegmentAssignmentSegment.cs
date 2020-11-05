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
    /// SegmentAssignmentSegment
    /// </summary>
    [DataContract]
    public partial class SegmentAssignmentSegment :  IEquatable<SegmentAssignmentSegment>
    {
        
        
        
        
        
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Session for "Session"
            /// </summary>
            [EnumMember(Value = "Session")]
            Session,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAssignmentSegment" /> class.
        /// </summary>
        /// <param name="Scope">The target entity that a segment applies to..</param>
        /// <param name="Version">The version of the segment..</param>
        public SegmentAssignmentSegment(ScopeEnum? Scope = null, int? Version = null)
        {
            this.Scope = Scope;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        
        
        /// <summary>
        /// The version of the segment.
        /// </summary>
        /// <value>The version of the segment.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
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
            sb.Append("class SegmentAssignmentSegment {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as SegmentAssignmentSegment);
        }

        /// <summary>
        /// Returns true if SegmentAssignmentSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentAssignmentSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentAssignmentSegment other)
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
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
