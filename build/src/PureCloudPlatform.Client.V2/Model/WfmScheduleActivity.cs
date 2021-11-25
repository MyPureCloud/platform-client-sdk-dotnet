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
    /// WfmScheduleActivity
    /// </summary>
    [DataContract]
    public partial class WfmScheduleActivity :  IEquatable<WfmScheduleActivity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmScheduleActivity" /> class.
        /// </summary>
        public WfmScheduleActivity()
        {
            
        }
        
        
        
        /// <summary>
        /// ID of user that the schedule is for
        /// </summary>
        /// <value>ID of user that the schedule is for</value>
        [DataMember(Name="userReference", EmitDefaultValue=false)]
        public UserReference UserReference { get; private set; }
        
        
        
        /// <summary>
        /// List of user&#39;s scheduled activities
        /// </summary>
        /// <value>List of user&#39;s scheduled activities</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<ScheduleActivity> Activities { get; private set; }
        
        
        
        /// <summary>
        /// List of user&#39;s days off
        /// </summary>
        /// <value>List of user&#39;s days off</value>
        [DataMember(Name="fullDayTimeOffMarkers", EmitDefaultValue=false)]
        public List<FullDayTimeOffMarker> FullDayTimeOffMarkers { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmScheduleActivity {\n");
            
            sb.Append("  UserReference: ").Append(UserReference).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(obj as WfmScheduleActivity);
        }

        /// <summary>
        /// Returns true if WfmScheduleActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmScheduleActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmScheduleActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserReference == other.UserReference ||
                    this.UserReference != null &&
                    this.UserReference.Equals(other.UserReference)
                ) &&
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                
                if (this.UserReference != null)
                    hash = hash * 59 + this.UserReference.GetHashCode();
                
                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();
                
                if (this.FullDayTimeOffMarkers != null)
                    hash = hash * 59 + this.FullDayTimeOffMarkers.GetHashCode();
                
                return hash;
            }
        }
    }

}
