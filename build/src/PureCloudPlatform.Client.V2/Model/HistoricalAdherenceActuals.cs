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
    /// HistoricalAdherenceActuals
    /// </summary>
    [DataContract]
    public partial class HistoricalAdherenceActuals :  IEquatable<HistoricalAdherenceActuals>
    {
        
        
        /// <summary>
        /// Activity in which the user is actually engaged
        /// </summary>
        /// <value>Activity in which the user is actually engaged</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActualActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Activity in which the user is actually engaged
        /// </summary>
        /// <value>Activity in which the user is actually engaged</value>
        [DataMember(Name="actualActivityCategory", EmitDefaultValue=false)]
        public ActualActivityCategoryEnum? ActualActivityCategory { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalAdherenceActuals" /> class.
        /// </summary>
        /// <param name="ActualActivityCategory">Activity in which the user is actually engaged.</param>
        /// <param name="StartOffsetSeconds">Actual start offset in seconds relative to query start time.</param>
        /// <param name="EndOffsetSeconds">Actual end offset in seconds relative to query start time.</param>
        public HistoricalAdherenceActuals(ActualActivityCategoryEnum? ActualActivityCategory = null, int? StartOffsetSeconds = null, int? EndOffsetSeconds = null)
        {
            this.ActualActivityCategory = ActualActivityCategory;
            this.StartOffsetSeconds = StartOffsetSeconds;
            this.EndOffsetSeconds = EndOffsetSeconds;
            
        }
        
        
        
        
        
        /// <summary>
        /// Actual start offset in seconds relative to query start time
        /// </summary>
        /// <value>Actual start offset in seconds relative to query start time</value>
        [DataMember(Name="startOffsetSeconds", EmitDefaultValue=false)]
        public int? StartOffsetSeconds { get; set; }
        
        
        
        /// <summary>
        /// Actual end offset in seconds relative to query start time
        /// </summary>
        /// <value>Actual end offset in seconds relative to query start time</value>
        [DataMember(Name="endOffsetSeconds", EmitDefaultValue=false)]
        public int? EndOffsetSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalAdherenceActuals {\n");
            
            sb.Append("  ActualActivityCategory: ").Append(ActualActivityCategory).Append("\n");
            sb.Append("  StartOffsetSeconds: ").Append(StartOffsetSeconds).Append("\n");
            sb.Append("  EndOffsetSeconds: ").Append(EndOffsetSeconds).Append("\n");
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
            return this.Equals(obj as HistoricalAdherenceActuals);
        }

        /// <summary>
        /// Returns true if HistoricalAdherenceActuals instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalAdherenceActuals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalAdherenceActuals other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActualActivityCategory == other.ActualActivityCategory ||
                    this.ActualActivityCategory != null &&
                    this.ActualActivityCategory.Equals(other.ActualActivityCategory)
                ) &&
                (
                    this.StartOffsetSeconds == other.StartOffsetSeconds ||
                    this.StartOffsetSeconds != null &&
                    this.StartOffsetSeconds.Equals(other.StartOffsetSeconds)
                ) &&
                (
                    this.EndOffsetSeconds == other.EndOffsetSeconds ||
                    this.EndOffsetSeconds != null &&
                    this.EndOffsetSeconds.Equals(other.EndOffsetSeconds)
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
                
                if (this.ActualActivityCategory != null)
                    hash = hash * 59 + this.ActualActivityCategory.GetHashCode();
                
                if (this.StartOffsetSeconds != null)
                    hash = hash * 59 + this.StartOffsetSeconds.GetHashCode();
                
                if (this.EndOffsetSeconds != null)
                    hash = hash * 59 + this.EndOffsetSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
