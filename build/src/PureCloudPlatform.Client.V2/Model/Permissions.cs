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
    /// Permissions
    /// </summary>
    [DataContract]
    public partial class Permissions :  IEquatable<Permissions>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Permissions() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions" /> class.
        /// </summary>
        /// <param name="Ids">List of permission ids. (required).</param>
        public Permissions(List<string> Ids = null)
        {
            this.Ids = Ids;
            
        }
        
        
        
        /// <summary>
        /// List of permission ids.
        /// </summary>
        /// <value>List of permission ids.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permissions {\n");
            
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(obj as Permissions);
        }

        /// <summary>
        /// Returns true if Permissions instances are equal
        /// </summary>
        /// <param name="other">Instance of Permissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permissions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
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
                
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();
                
                return hash;
            }
        }
    }

}
