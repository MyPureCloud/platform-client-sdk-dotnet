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
    /// ImportScriptStatusResponse
    /// </summary>
    [DataContract]
    public partial class ImportScriptStatusResponse :  IEquatable<ImportScriptStatusResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportScriptStatusResponse" /> class.
        /// </summary>
        
        
        /// <param name="Url">Url.</param>
        
        
        
        /// <param name="Succeeded">Succeeded.</param>
        
        
        
        /// <param name="Message">Message.</param>
        
        
        public ImportScriptStatusResponse(string Url = null, bool? Succeeded = null, string Message = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Url = Url;
            
            
            
            
            
            
            
            
this.Succeeded = Succeeded;
            
            
            
            
            
            
            
            
this.Message = Message;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name="succeeded", EmitDefaultValue=false)]
        public bool? Succeeded { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportScriptStatusResponse {\n");
            
            sb.Append("  Url: ").Append(Url).Append("\n");
            
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            
            sb.Append("  Message: ").Append(Message).Append("\n");
            
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
            return this.Equals(obj as ImportScriptStatusResponse);
        }

        /// <summary>
        /// Returns true if ImportScriptStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportScriptStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportScriptStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Succeeded == other.Succeeded ||
                    this.Succeeded != null &&
                    this.Succeeded.Equals(other.Succeeded)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.Succeeded != null)
                    hash = hash * 59 + this.Succeeded.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                return hash;
            }
        }
    }

}
