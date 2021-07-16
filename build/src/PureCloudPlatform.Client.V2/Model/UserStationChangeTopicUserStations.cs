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
    /// UserStationChangeTopicUserStations
    /// </summary>
    [DataContract]
    public partial class UserStationChangeTopicUserStations :  IEquatable<UserStationChangeTopicUserStations>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStationChangeTopicUserStations" /> class.
        /// </summary>
        /// <param name="AssociatedStation">AssociatedStation.</param>
        public UserStationChangeTopicUserStations(UserStationChangeTopicUserStation AssociatedStation = null)
        {
            this.AssociatedStation = AssociatedStation;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets AssociatedStation
        /// </summary>
        [DataMember(Name="associatedStation", EmitDefaultValue=false)]
        public UserStationChangeTopicUserStation AssociatedStation { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStationChangeTopicUserStations {\n");
            
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
            return this.Equals(obj as UserStationChangeTopicUserStations);
        }

        /// <summary>
        /// Returns true if UserStationChangeTopicUserStations instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStationChangeTopicUserStations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStationChangeTopicUserStations other)
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
