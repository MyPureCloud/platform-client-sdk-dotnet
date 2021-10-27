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
    /// GamificationScorecardChangeTopicPunctualityEvent
    /// </summary>
    [DataContract]
    public partial class GamificationScorecardChangeTopicPunctualityEvent :  IEquatable<GamificationScorecardChangeTopicPunctualityEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicPunctualityEvent" /> class.
        /// </summary>
        /// <param name="DateStart">DateStart.</param>
        /// <param name="DateScheduleStart">DateScheduleStart.</param>
        /// <param name="ActivityCode">ActivityCode.</param>
        /// <param name="Points">Points.</param>
        public GamificationScorecardChangeTopicPunctualityEvent(string DateStart = null, string DateScheduleStart = null, string ActivityCode = null, int? Points = null)
        {
            this.DateStart = DateStart;
            this.DateScheduleStart = DateScheduleStart;
            this.ActivityCode = ActivityCode;
            this.Points = Points;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets DateStart
        /// </summary>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public string DateStart { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateScheduleStart
        /// </summary>
        [DataMember(Name="dateScheduleStart", EmitDefaultValue=false)]
        public string DateScheduleStart { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActivityCode
        /// </summary>
        [DataMember(Name="activityCode", EmitDefaultValue=false)]
        public string ActivityCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamificationScorecardChangeTopicPunctualityEvent {\n");
            
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateScheduleStart: ").Append(DateScheduleStart).Append("\n");
            sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(obj as GamificationScorecardChangeTopicPunctualityEvent);
        }

        /// <summary>
        /// Returns true if GamificationScorecardChangeTopicPunctualityEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of GamificationScorecardChangeTopicPunctualityEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamificationScorecardChangeTopicPunctualityEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateScheduleStart == other.DateScheduleStart ||
                    this.DateScheduleStart != null &&
                    this.DateScheduleStart.Equals(other.DateScheduleStart)
                ) &&
                (
                    this.ActivityCode == other.ActivityCode ||
                    this.ActivityCode != null &&
                    this.ActivityCode.Equals(other.ActivityCode)
                ) &&
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
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
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.DateScheduleStart != null)
                    hash = hash * 59 + this.DateScheduleStart.GetHashCode();
                
                if (this.ActivityCode != null)
                    hash = hash * 59 + this.ActivityCode.GetHashCode();
                
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                
                return hash;
            }
        }
    }

}
