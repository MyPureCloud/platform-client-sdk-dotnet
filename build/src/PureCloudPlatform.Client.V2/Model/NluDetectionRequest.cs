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
    /// NluDetectionRequest
    /// </summary>
    [DataContract]
    public partial class NluDetectionRequest :  IEquatable<NluDetectionRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluDetectionRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
        /// </summary>
        /// <param name="Input">The input subject to NLU detection. (required).</param>
        /// <param name="Context">The context for the input to NLU detection..</param>
        public NluDetectionRequest(NluDetectionInput Input = null, NluDetectionContext Context = null)
        {
            this.Input = Input;
            this.Context = Context;
            
        }
        
        
        
        /// <summary>
        /// The input subject to NLU detection.
        /// </summary>
        /// <value>The input subject to NLU detection.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public NluDetectionInput Input { get; set; }
        
        
        
        /// <summary>
        /// The context for the input to NLU detection.
        /// </summary>
        /// <value>The context for the input to NLU detection.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public NluDetectionContext Context { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluDetectionRequest {\n");
            
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as NluDetectionRequest);
        }

        /// <summary>
        /// Returns true if NluDetectionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NluDetectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluDetectionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
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
                
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                
                return hash;
            }
        }
    }

}
