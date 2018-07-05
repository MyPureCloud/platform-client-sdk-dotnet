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
    /// UserStationsNotification
    /// </summary>
    [DataContract]
    public partial class UserStationsNotification :  IEquatable<UserStationsNotification>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStationsNotification" /> class.
        /// </summary>
        /// <param name="AssociatedStation">AssociatedStation.</param>
        public UserStationsNotification(UserStationsNotificationAssociatedStation AssociatedStation = null)
        {
            this.AssociatedStation = AssociatedStation;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets AssociatedStation
        /// </summary>
        [DataMember(Name="associatedStation", EmitDefaultValue=false)]
        public UserStationsNotificationAssociatedStation AssociatedStation { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStationsNotification {\n");
            
            sb.Append("  AssociatedStation: ").Append(AssociatedStation).Append("\n");
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
            return this.Equals(obj as UserStationsNotification);
        }

        /// <summary>
        /// Returns true if UserStationsNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStationsNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStationsNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssociatedStation == other.AssociatedStation ||
                    this.AssociatedStation != null &&
                    this.AssociatedStation.Equals(other.AssociatedStation)
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
                
                if (this.AssociatedStation != null)
                    hash = hash * 59 + this.AssociatedStation.GetHashCode();
                
                return hash;
            }
        }
    }

}
