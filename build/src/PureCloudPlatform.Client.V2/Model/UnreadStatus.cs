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
    /// UnreadStatus
    /// </summary>
    [DataContract]
    public partial class UnreadStatus :  IEquatable<UnreadStatus>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnreadStatus" /> class.
        /// </summary>
        
        
        /// <param name="Unread">Sets if the alert is read or unread..</param>
        
        
        public UnreadStatus(bool? Unread = null)
        {
            
            
            
            
            
            
            
            
            
            
this.Unread = Unread;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Sets if the alert is read or unread.
        /// </summary>
        /// <value>Sets if the alert is read or unread.</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool? Unread { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnreadStatus {\n");
            
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            
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
            return this.Equals(obj as UnreadStatus);
        }

        /// <summary>
        /// Returns true if UnreadStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of UnreadStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnreadStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
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
                
                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();
                
                return hash;
            }
        }
    }

}
