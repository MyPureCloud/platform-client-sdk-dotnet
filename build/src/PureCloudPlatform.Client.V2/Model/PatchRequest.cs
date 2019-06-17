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
    /// PatchRequest
    /// </summary>
    [DataContract]
    public partial class PatchRequest :  IEquatable<PatchRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRequest" /> class.
        /// </summary>
        /// <param name="Schemas">Schemas.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="Operations">Operations (required).</param>
        /// <param name="Meta">Meta.</param>
        public PatchRequest(List<string> Schemas = null, string Id = null, string ExternalId = null, List<PatchOperation> Operations = null, Meta Meta = null)
        {
            this.Schemas = Schemas;
            this.Id = Id;
            this.ExternalId = ExternalId;
            this.Operations = Operations;
            this.Meta = Meta;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Schemas
        /// </summary>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name="Operations", EmitDefaultValue=false)]
        public List<PatchOperation> Operations { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchRequest {\n");
            
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
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
            return this.Equals(obj as PatchRequest);
        }

        /// <summary>
        /// Returns true if PatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) &&
                (
                    this.Operations == other.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(other.Operations)
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
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.Operations != null)
                    hash = hash * 59 + this.Operations.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }
    }

}
