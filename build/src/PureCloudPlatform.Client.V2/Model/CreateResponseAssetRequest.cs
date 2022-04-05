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
    /// CreateResponseAssetRequest
    /// </summary>
    [DataContract]
    public partial class CreateResponseAssetRequest :  IEquatable<CreateResponseAssetRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseAssetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateResponseAssetRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseAssetRequest" /> class.
        /// </summary>
        /// <param name="Name">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#| (required).</param>
        /// <param name="DivisionId">Division to associate to this asset. Can only be used with this division..</param>
        /// <param name="ContentMd5">Content MD-5 of the file to upload.</param>
        public CreateResponseAssetRequest(string Name = null, string DivisionId = null, string ContentMd5 = null)
        {
            this.Name = Name;
            this.DivisionId = DivisionId;
            this.ContentMd5 = ContentMd5;
            
        }
        
        
        
        /// <summary>
        /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#|
        /// </summary>
        /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#|</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Division to associate to this asset. Can only be used with this division.
        /// </summary>
        /// <value>Division to associate to this asset. Can only be used with this division.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }
        
        
        
        /// <summary>
        /// Content MD-5 of the file to upload
        /// </summary>
        /// <value>Content MD-5 of the file to upload</value>
        [DataMember(Name="contentMd5", EmitDefaultValue=false)]
        public string ContentMd5 { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResponseAssetRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
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
            return this.Equals(obj as CreateResponseAssetRequest);
        }

        /// <summary>
        /// Returns true if CreateResponseAssetRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateResponseAssetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResponseAssetRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.ContentMd5 == other.ContentMd5 ||
                    this.ContentMd5 != null &&
                    this.ContentMd5.Equals(other.ContentMd5)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();
                
                if (this.ContentMd5 != null)
                    hash = hash * 59 + this.ContentMd5.GetHashCode();
                
                return hash;
            }
        }
    }

}
