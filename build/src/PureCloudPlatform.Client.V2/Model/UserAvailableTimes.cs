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
    /// UserAvailableTimes
    /// </summary>
    [DataContract]
    public partial class UserAvailableTimes :  IEquatable<UserAvailableTimes>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAvailableTimes" /> class.
        /// </summary>
        /// <param name="User">User reference.</param>
        /// <param name="AvailableTimes">Periods of availability to schedule coaching appointment for an user.</param>
        public UserAvailableTimes(UserReference User = null, List<AvailableTime> AvailableTimes = null)
        {
            this.User = User;
            this.AvailableTimes = AvailableTimes;
            
        }
        
        
        
        /// <summary>
        /// User reference
        /// </summary>
        /// <value>User reference</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }
        
        
        
        /// <summary>
        /// Periods of availability to schedule coaching appointment for an user
        /// </summary>
        /// <value>Periods of availability to schedule coaching appointment for an user</value>
        [DataMember(Name="availableTimes", EmitDefaultValue=false)]
        public List<AvailableTime> AvailableTimes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAvailableTimes {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  AvailableTimes: ").Append(AvailableTimes).Append("\n");
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
            return this.Equals(obj as UserAvailableTimes);
        }

        /// <summary>
        /// Returns true if UserAvailableTimes instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAvailableTimes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAvailableTimes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.AvailableTimes == other.AvailableTimes ||
                    this.AvailableTimes != null &&
                    this.AvailableTimes.SequenceEqual(other.AvailableTimes)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.AvailableTimes != null)
                    hash = hash * 59 + this.AvailableTimes.GetHashCode();
                
                return hash;
            }
        }
    }

}
