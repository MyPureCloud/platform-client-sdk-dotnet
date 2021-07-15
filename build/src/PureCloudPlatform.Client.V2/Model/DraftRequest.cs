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
    /// DraftRequest
    /// </summary>
    [DataContract]
    public partial class DraftRequest :  IEquatable<DraftRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftRequest" /> class.
        /// </summary>
        /// <param name="Intents">Draft intent object..</param>
        public DraftRequest(List<DraftIntents> Intents = null)
        {
            this.Intents = Intents;
            
        }
        
        
        
        /// <summary>
        /// Draft intent object.
        /// </summary>
        /// <value>Draft intent object.</value>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public List<DraftIntents> Intents { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftRequest {\n");
            
            sb.Append("  Intents: ").Append(Intents).Append("\n");
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
            return this.Equals(obj as DraftRequest);
        }

        /// <summary>
        /// Returns true if DraftRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DraftRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DraftRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Intents == other.Intents ||
                    this.Intents != null &&
                    this.Intents.SequenceEqual(other.Intents)
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
                
                if (this.Intents != null)
                    hash = hash * 59 + this.Intents.GetHashCode();
                
                return hash;
            }
        }
    }

}
