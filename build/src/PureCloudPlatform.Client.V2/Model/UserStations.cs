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
    /// UserStations
    /// </summary>
    [DataContract]
    public partial class UserStations :  IEquatable<UserStations>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStations" /> class.
        /// </summary>
        /// <param name="AssociatedStation">Current associated station for this user..</param>
        /// <param name="EffectiveStation">The station where the user can be reached based on their default and associated station..</param>
        /// <param name="DefaultStation">Default station to be used if not associated with a station..</param>
        /// <param name="LastAssociatedStation">Last associated station for this user..</param>
        public UserStations(UserStation AssociatedStation = null, UserStation EffectiveStation = null, UserStation DefaultStation = null, UserStation LastAssociatedStation = null)
        {
            this.AssociatedStation = AssociatedStation;
            this.EffectiveStation = EffectiveStation;
            this.DefaultStation = DefaultStation;
            this.LastAssociatedStation = LastAssociatedStation;
            
        }
        
        
        
        /// <summary>
        /// Current associated station for this user.
        /// </summary>
        /// <value>Current associated station for this user.</value>
        [DataMember(Name="associatedStation", EmitDefaultValue=false)]
        public UserStation AssociatedStation { get; set; }
        
        
        
        /// <summary>
        /// The station where the user can be reached based on their default and associated station.
        /// </summary>
        /// <value>The station where the user can be reached based on their default and associated station.</value>
        [DataMember(Name="effectiveStation", EmitDefaultValue=false)]
        public UserStation EffectiveStation { get; set; }
        
        
        
        /// <summary>
        /// Default station to be used if not associated with a station.
        /// </summary>
        /// <value>Default station to be used if not associated with a station.</value>
        [DataMember(Name="defaultStation", EmitDefaultValue=false)]
        public UserStation DefaultStation { get; set; }
        
        
        
        /// <summary>
        /// Last associated station for this user.
        /// </summary>
        /// <value>Last associated station for this user.</value>
        [DataMember(Name="lastAssociatedStation", EmitDefaultValue=false)]
        public UserStation LastAssociatedStation { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStations {\n");
            
            sb.Append("  AssociatedStation: ").Append(AssociatedStation).Append("\n");
            sb.Append("  EffectiveStation: ").Append(EffectiveStation).Append("\n");
            sb.Append("  DefaultStation: ").Append(DefaultStation).Append("\n");
            sb.Append("  LastAssociatedStation: ").Append(LastAssociatedStation).Append("\n");
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
            return this.Equals(obj as UserStations);
        }

        /// <summary>
        /// Returns true if UserStations instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssociatedStation == other.AssociatedStation ||
                    this.AssociatedStation != null &&
                    this.AssociatedStation.Equals(other.AssociatedStation)
                ) &&
                (
                    this.EffectiveStation == other.EffectiveStation ||
                    this.EffectiveStation != null &&
                    this.EffectiveStation.Equals(other.EffectiveStation)
                ) &&
                (
                    this.DefaultStation == other.DefaultStation ||
                    this.DefaultStation != null &&
                    this.DefaultStation.Equals(other.DefaultStation)
                ) &&
                (
                    this.LastAssociatedStation == other.LastAssociatedStation ||
                    this.LastAssociatedStation != null &&
                    this.LastAssociatedStation.Equals(other.LastAssociatedStation)
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
                
                if (this.EffectiveStation != null)
                    hash = hash * 59 + this.EffectiveStation.GetHashCode();
                
                if (this.DefaultStation != null)
                    hash = hash * 59 + this.DefaultStation.GetHashCode();
                
                if (this.LastAssociatedStation != null)
                    hash = hash * 59 + this.LastAssociatedStation.GetHashCode();
                
                return hash;
            }
        }
    }

}
