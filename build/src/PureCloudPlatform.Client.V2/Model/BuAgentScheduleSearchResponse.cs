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
    /// BuAgentScheduleSearchResponse
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleSearchResponse :  IEquatable<BuAgentScheduleSearchResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleSearchResponse" /> class.
        /// </summary>
        /// <param name="User">The user to whom this agent schedule applies.</param>
        /// <param name="Shifts">The shift definitions for this agent schedule.</param>
        /// <param name="FullDayTimeOffMarkers">Full day time off markers which apply to this agent schedule.</param>
        public BuAgentScheduleSearchResponse(UserReference User = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null)
        {
            this.User = User;
            this.Shifts = Shifts;
            this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;
            
        }
        
        
        
        /// <summary>
        /// The user to whom this agent schedule applies
        /// </summary>
        /// <value>The user to whom this agent schedule applies</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }
        
        
        
        /// <summary>
        /// The shift definitions for this agent schedule
        /// </summary>
        /// <value>The shift definitions for this agent schedule</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<BuAgentScheduleShift> Shifts { get; set; }
        
        
        
        /// <summary>
        /// Full day time off markers which apply to this agent schedule
        /// </summary>
        /// <value>Full day time off markers which apply to this agent schedule</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentScheduleSearchResponse {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleSearchResponse);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleSearchResponse other)
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
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                    this.FullDayTimeOffMarkers != null &&
                    this.FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
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
                
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                
                return hash;
            }
        }
    }

}
