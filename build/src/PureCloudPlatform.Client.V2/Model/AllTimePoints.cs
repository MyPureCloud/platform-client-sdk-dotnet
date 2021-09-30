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
    /// AllTimePoints
    /// </summary>
    [DataContract]
    public partial class AllTimePoints :  IEquatable<AllTimePoints>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AllTimePoints" /> class.
        /// </summary>
        public AllTimePoints()
        {
            
        }
        
        
        
        /// <summary>
        /// Queried user
        /// </summary>
        /// <value>Queried user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; private set; }
        
        
        
        /// <summary>
        /// Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEndWorkday", EmitDefaultValue=false)]
        public String DateEndWorkday { get; private set; }
        
        
        
        /// <summary>
        /// All time point collected bt the user
        /// </summary>
        /// <value>All time point collected bt the user</value>
        [DataMember(Name="allTimePoints", EmitDefaultValue=false)]
        public long? _AllTimePoints { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllTimePoints {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
            sb.Append("  _AllTimePoints: ").Append(_AllTimePoints).Append("\n");
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
            return this.Equals(obj as AllTimePoints);
        }

        /// <summary>
        /// Returns true if AllTimePoints instances are equal
        /// </summary>
        /// <param name="other">Instance of AllTimePoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllTimePoints other)
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
                    this.DateEndWorkday == other.DateEndWorkday ||
                    this.DateEndWorkday != null &&
                    this.DateEndWorkday.Equals(other.DateEndWorkday)
                ) &&
                (
                    this._AllTimePoints == other._AllTimePoints ||
                    this._AllTimePoints != null &&
                    this._AllTimePoints.Equals(other._AllTimePoints)
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
                
                if (this.DateEndWorkday != null)
                    hash = hash * 59 + this.DateEndWorkday.GetHashCode();
                
                if (this._AllTimePoints != null)
                    hash = hash * 59 + this._AllTimePoints.GetHashCode();
                
                return hash;
            }
        }
    }

}
