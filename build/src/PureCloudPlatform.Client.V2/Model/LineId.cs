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
    /// User information for a Line account
    /// </summary>
    [DataContract]
    public partial class LineId :  IEquatable<LineId>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineId" /> class.
        /// </summary>
        /// <param name="Ids">The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with..</param>
        /// <param name="DisplayName">The displayName of this person&#39;s account in Line.</param>
        public LineId(List<LineUserId> Ids = null, string DisplayName = null)
        {
            this.Ids = Ids;
            this.DisplayName = DisplayName;
            
        }
        
        
        
        /// <summary>
        /// The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.
        /// </summary>
        /// <value>The set of Line userIds that this person has. Each userId is specific to the Line channel that the user interacts with.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<LineUserId> Ids { get; set; }
        
        
        
        /// <summary>
        /// The displayName of this person&#39;s account in Line
        /// </summary>
        /// <value>The displayName of this person&#39;s account in Line</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineId {\n");
            
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(obj as LineId);
        }

        /// <summary>
        /// Returns true if LineId instances are equal
        /// </summary>
        /// <param name="other">Instance of LineId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                return hash;
            }
        }
    }

}
