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
    /// MessagingTemplateRequest
    /// </summary>
    [DataContract]
    public partial class MessagingTemplateRequest :  IEquatable<MessagingTemplateRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTemplateRequest" /> class.
        /// </summary>
        /// <param name="ResponseId">A Response Management response identifier for a messaging template defined response.</param>
        /// <param name="Parameters">A list of Response Management response substitutions for the response&#39;s messaging template.</param>
        public MessagingTemplateRequest(string ResponseId = null, List<TemplateParameter> Parameters = null)
        {
            this.ResponseId = ResponseId;
            this.Parameters = Parameters;
            
        }
        
        
        
        /// <summary>
        /// A Response Management response identifier for a messaging template defined response
        /// </summary>
        /// <value>A Response Management response identifier for a messaging template defined response</value>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }
        
        
        
        /// <summary>
        /// A list of Response Management response substitutions for the response&#39;s messaging template
        /// </summary>
        /// <value>A list of Response Management response substitutions for the response&#39;s messaging template</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<TemplateParameter> Parameters { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingTemplateRequest {\n");
            
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as MessagingTemplateRequest);
        }

        /// <summary>
        /// Returns true if MessagingTemplateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingTemplateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ResponseId == other.ResponseId ||
                    this.ResponseId != null &&
                    this.ResponseId.Equals(other.ResponseId)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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
                
                if (this.ResponseId != null)
                    hash = hash * 59 + this.ResponseId.GetHashCode();
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                return hash;
            }
        }
    }

}