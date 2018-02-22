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
    /// PublishForm
    /// </summary>
    [DataContract]
    public partial class PublishForm :  IEquatable<PublishForm>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublishForm() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishForm" /> class.
        /// </summary>
        
        
        /// <param name="Published">Is this form published (required).</param>
        
        
        
        /// <param name="ContextId">Unique Id for all versions of this form (required).</param>
        
        
        public PublishForm(bool? Published = null, string ContextId = null)
        {
            
            
            
            // to ensure "Published" is required (not null)
            if (Published == null)
            {
                throw new InvalidDataException("Published is a required property for PublishForm and cannot be null");
            }
            else
            {
                this.Published = Published;
            }
            
            
            
            
            
            // to ensure "ContextId" is required (not null)
            if (ContextId == null)
            {
                throw new InvalidDataException("ContextId is a required property for PublishForm and cannot be null");
            }
            else
            {
                this.ContextId = ContextId;
            }
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Is this form published
        /// </summary>
        /// <value>Is this form published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        
        
        
        /// <summary>
        /// Unique Id for all versions of this form
        /// </summary>
        /// <value>Unique Id for all versions of this form</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishForm {\n");
            
            sb.Append("  Published: ").Append(Published).Append("\n");
            
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            
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
            return this.Equals(obj as PublishForm);
        }

        /// <summary>
        /// Returns true if PublishForm instances are equal
        /// </summary>
        /// <param name="other">Instance of PublishForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishForm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
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
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                return hash;
            }
        }
    }

}
