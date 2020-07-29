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
    /// Defines the list response for SCIM resource types.
    /// </summary>
    [DataContract]
    public partial class ScimV2SchemaListResponse :  IEquatable<ScimV2SchemaListResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2SchemaListResponse" /> class.
        /// </summary>
        /// <param name="Resources">The list of requested resources..</param>
        /// <param name="Schemas">The list of supported schemas..</param>
        public ScimV2SchemaListResponse(List<ScimV2SchemaDefinition> Resources = null, List<string> Schemas = null)
        {
            this.Resources = Resources;
            this.Schemas = Schemas;
            
        }
        
        
        
        /// <summary>
        /// The total number of results.
        /// </summary>
        /// <value>The total number of results.</value>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public long? TotalResults { get; private set; }
        
        
        
        /// <summary>
        /// The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.
        /// </summary>
        /// <value>The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.</value>
        [DataMember(Name="startIndex", EmitDefaultValue=false)]
        public long? StartIndex { get; private set; }
        
        
        
        /// <summary>
        /// The number of resources returned per page.
        /// </summary>
        /// <value>The number of resources returned per page.</value>
        [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
        public long? ItemsPerPage { get; private set; }
        
        
        
        /// <summary>
        /// The list of requested resources.
        /// </summary>
        /// <value>The list of requested resources.</value>
        [DataMember(Name="Resources", EmitDefaultValue=false)]
        public List<ScimV2SchemaDefinition> Resources { get; set; }
        
        
        
        /// <summary>
        /// The list of supported schemas.
        /// </summary>
        /// <value>The list of supported schemas.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2SchemaListResponse {\n");
            
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
            return this.Equals(obj as ScimV2SchemaListResponse);
        }

        /// <summary>
        /// Returns true if ScimV2SchemaListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2SchemaListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2SchemaListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalResults == other.TotalResults ||
                    this.TotalResults != null &&
                    this.TotalResults.Equals(other.TotalResults)
                ) &&
                (
                    this.StartIndex == other.StartIndex ||
                    this.StartIndex != null &&
                    this.StartIndex.Equals(other.StartIndex)
                ) &&
                (
                    this.ItemsPerPage == other.ItemsPerPage ||
                    this.ItemsPerPage != null &&
                    this.ItemsPerPage.Equals(other.ItemsPerPage)
                ) &&
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
                ) &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
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
                
                if (this.TotalResults != null)
                    hash = hash * 59 + this.TotalResults.GetHashCode();
                
                if (this.StartIndex != null)
                    hash = hash * 59 + this.StartIndex.GetHashCode();
                
                if (this.ItemsPerPage != null)
                    hash = hash * 59 + this.ItemsPerPage.GetHashCode();
                
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                return hash;
            }
        }
    }

}
