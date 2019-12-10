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
    /// Defines a SCIM group.
    /// </summary>
    [DataContract]
    public partial class ScimV2Group :  IEquatable<ScimV2Group>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2Group" /> class.
        /// </summary>
        /// <param name="Schemas">The list of supported schemas..</param>
        /// <param name="Members">The list of members in the group..</param>
        /// <param name="Meta">The metadata of the SCIM resource..</param>
        public ScimV2Group(List<string> Schemas = null, List<ScimV2MemberReference> Members = null, ScimMetadata Meta = null)
        {
            this.Schemas = Schemas;
            this.Members = Members;
            this.Meta = Meta;
            
        }
        
        
        
        /// <summary>
        /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;.
        /// </summary>
        /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;Mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;Returned\&quot; is set to \&quot;always\&quot;.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The list of supported schemas.
        /// </summary>
        /// <value>The list of supported schemas.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        
        /// <summary>
        /// The display name of the group.
        /// </summary>
        /// <value>The display name of the group.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }
        
        
        
        /// <summary>
        /// The list of members in the group.
        /// </summary>
        /// <value>The list of members in the group.</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<ScimV2MemberReference> Members { get; set; }
        
        
        
        /// <summary>
        /// The metadata of the SCIM resource.
        /// </summary>
        /// <value>The metadata of the SCIM resource.</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public ScimMetadata Meta { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2Group {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(obj as ScimV2Group);
        }

        /// <summary>
        /// Returns true if ScimV2Group instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2Group other)
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
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) &&
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }
    }

}
