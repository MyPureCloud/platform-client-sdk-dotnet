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
    /// The messaging template identifies a structured message templates supported by a messaging channel. For example, WhatsApp
    /// </summary>
    [DataContract]
    public partial class MessagingTemplate :  IEquatable<MessagingTemplate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingTemplate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTemplate" /> class.
        /// </summary>
        /// <param name="Name">The messaging template name. (required).</param>
        /// <param name="_Namespace">The messaging template namespace. (required).</param>
        /// <param name="Language">The messaging template language. For example, &#39;en-US&#39; (required).</param>
        public MessagingTemplate(string Name = null, string _Namespace = null, string Language = null)
        {
            this.Name = Name;
            this._Namespace = _Namespace;
            this.Language = Language;
            
        }
        
        
        
        /// <summary>
        /// The messaging template name.
        /// </summary>
        /// <value>The messaging template name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The messaging template namespace.
        /// </summary>
        /// <value>The messaging template namespace.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }
        
        
        
        /// <summary>
        /// The messaging template language. For example, &#39;en-US&#39;
        /// </summary>
        /// <value>The messaging template language. For example, &#39;en-US&#39;</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingTemplate {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(obj as MessagingTemplate);
        }

        /// <summary>
        /// Returns true if MessagingTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingTemplate other)
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
                    this._Namespace == other._Namespace ||
                    this._Namespace != null &&
                    this._Namespace.Equals(other._Namespace)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
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
                
                if (this._Namespace != null)
                    hash = hash * 59 + this._Namespace.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                return hash;
            }
        }
    }

}
