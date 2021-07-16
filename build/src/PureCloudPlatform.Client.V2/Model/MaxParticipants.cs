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
    /// MaxParticipants
    /// </summary>
    [DataContract]
    public partial class MaxParticipants :  IEquatable<MaxParticipants>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxParticipants" /> class.
        /// </summary>
        /// <param name="_MaxParticipants">The maximum number of participants that are allowed on a conversation..</param>
        public MaxParticipants(int? _MaxParticipants = null)
        {
            this._MaxParticipants = _MaxParticipants;
            
        }
        
        
        
        /// <summary>
        /// The maximum number of participants that are allowed on a conversation.
        /// </summary>
        /// <value>The maximum number of participants that are allowed on a conversation.</value>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? _MaxParticipants { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaxParticipants {\n");
            
            sb.Append("  _MaxParticipants: ").Append(_MaxParticipants).Append("\n");
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
            return this.Equals(obj as MaxParticipants);
        }

        /// <summary>
        /// Returns true if MaxParticipants instances are equal
        /// </summary>
        /// <param name="other">Instance of MaxParticipants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaxParticipants other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this._MaxParticipants == other._MaxParticipants ||
                    this._MaxParticipants != null &&
                    this._MaxParticipants.Equals(other._MaxParticipants)
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
                
                if (this._MaxParticipants != null)
                    hash = hash * 59 + this._MaxParticipants.GetHashCode();
                
                return hash;
            }
        }
    }

}
