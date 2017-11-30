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
    /// Schedule Adherence Configuration
    /// </summary>
    [DataContract]
    public partial class AdherenceSettings :  IEquatable<AdherenceSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets IgnoredActivityCategories
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IgnoredActivityCategoriesEnum
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
        /// Initializes a new instance of the <see cref="AdherenceSettings" /> class.
        /// </summary>
        
        
        /// <param name="SevereAlertThresholdMinutes">The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence.</param>
        
        
        
        /// <param name="AdherenceTargetPercent">Target adherence percentage.</param>
        
        
        
        /// <param name="AdherenceExceptionThresholdSeconds">The threshold in seconds for which agents should not be penalized for being momentarily out of adherence.</param>
        
        
        
        /// <param name="NonOnQueueActivitiesEquivalent">Whether to treat all non-on-queue activities as equivalent for adherence purposes.</param>
        
        
        
        /// <param name="TrackOnQueueActivity">Whether to track on-queue activities.</param>
        
        
        
        /// <param name="IgnoredActivityCategories">Activity categories that should be ignored for adherence purposes.</param>
        
        
        public AdherenceSettings(int? SevereAlertThresholdMinutes = null, int? AdherenceTargetPercent = null, int? AdherenceExceptionThresholdSeconds = null, bool? NonOnQueueActivitiesEquivalent = null, bool? TrackOnQueueActivity = null, List<IgnoredActivityCategoriesEnum> IgnoredActivityCategories = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.SevereAlertThresholdMinutes = SevereAlertThresholdMinutes;
            
            
            
            
            
            
            
            
this.AdherenceTargetPercent = AdherenceTargetPercent;
            
            
            
            
            
            
            
            
this.AdherenceExceptionThresholdSeconds = AdherenceExceptionThresholdSeconds;
            
            
            
            
            
            
            
            
this.NonOnQueueActivitiesEquivalent = NonOnQueueActivitiesEquivalent;
            
            
            
            
            
            
            
            
this.TrackOnQueueActivity = TrackOnQueueActivity;
            
            
            
            
            
            
            
            
this.IgnoredActivityCategories = IgnoredActivityCategories;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence
        /// </summary>
        /// <value>The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence</value>
        [DataMember(Name="severeAlertThresholdMinutes", EmitDefaultValue=false)]
        public int? SevereAlertThresholdMinutes { get; set; }
        
        
        
        /// <summary>
        /// Target adherence percentage
        /// </summary>
        /// <value>Target adherence percentage</value>
        [DataMember(Name="adherenceTargetPercent", EmitDefaultValue=false)]
        public int? AdherenceTargetPercent { get; set; }
        
        
        
        /// <summary>
        /// The threshold in seconds for which agents should not be penalized for being momentarily out of adherence
        /// </summary>
        /// <value>The threshold in seconds for which agents should not be penalized for being momentarily out of adherence</value>
        [DataMember(Name="adherenceExceptionThresholdSeconds", EmitDefaultValue=false)]
        public int? AdherenceExceptionThresholdSeconds { get; set; }
        
        
        
        /// <summary>
        /// Whether to treat all non-on-queue activities as equivalent for adherence purposes
        /// </summary>
        /// <value>Whether to treat all non-on-queue activities as equivalent for adherence purposes</value>
        [DataMember(Name="nonOnQueueActivitiesEquivalent", EmitDefaultValue=false)]
        public bool? NonOnQueueActivitiesEquivalent { get; set; }
        
        
        
        /// <summary>
        /// Whether to track on-queue activities
        /// </summary>
        /// <value>Whether to track on-queue activities</value>
        [DataMember(Name="trackOnQueueActivity", EmitDefaultValue=false)]
        public bool? TrackOnQueueActivity { get; set; }
        
        
        
        /// <summary>
        /// Activity categories that should be ignored for adherence purposes
        /// </summary>
        /// <value>Activity categories that should be ignored for adherence purposes</value>
        [DataMember(Name="ignoredActivityCategories", EmitDefaultValue=false)]
        public List<IgnoredActivityCategoriesEnum> IgnoredActivityCategories { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdherenceSettings {\n");
            
            sb.Append("  SevereAlertThresholdMinutes: ").Append(SevereAlertThresholdMinutes).Append("\n");
            
            sb.Append("  AdherenceTargetPercent: ").Append(AdherenceTargetPercent).Append("\n");
            
            sb.Append("  AdherenceExceptionThresholdSeconds: ").Append(AdherenceExceptionThresholdSeconds).Append("\n");
            
            sb.Append("  NonOnQueueActivitiesEquivalent: ").Append(NonOnQueueActivitiesEquivalent).Append("\n");
            
            sb.Append("  TrackOnQueueActivity: ").Append(TrackOnQueueActivity).Append("\n");
            
            sb.Append("  IgnoredActivityCategories: ").Append(IgnoredActivityCategories).Append("\n");
            
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
            return this.Equals(obj as AdherenceSettings);
        }

        /// <summary>
        /// Returns true if AdherenceSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AdherenceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdherenceSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SevereAlertThresholdMinutes == other.SevereAlertThresholdMinutes ||
                    this.SevereAlertThresholdMinutes != null &&
                    this.SevereAlertThresholdMinutes.Equals(other.SevereAlertThresholdMinutes)
                ) &&
                (
                    this.AdherenceTargetPercent == other.AdherenceTargetPercent ||
                    this.AdherenceTargetPercent != null &&
                    this.AdherenceTargetPercent.Equals(other.AdherenceTargetPercent)
                ) &&
                (
                    this.AdherenceExceptionThresholdSeconds == other.AdherenceExceptionThresholdSeconds ||
                    this.AdherenceExceptionThresholdSeconds != null &&
                    this.AdherenceExceptionThresholdSeconds.Equals(other.AdherenceExceptionThresholdSeconds)
                ) &&
                (
                    this.NonOnQueueActivitiesEquivalent == other.NonOnQueueActivitiesEquivalent ||
                    this.NonOnQueueActivitiesEquivalent != null &&
                    this.NonOnQueueActivitiesEquivalent.Equals(other.NonOnQueueActivitiesEquivalent)
                ) &&
                (
                    this.TrackOnQueueActivity == other.TrackOnQueueActivity ||
                    this.TrackOnQueueActivity != null &&
                    this.TrackOnQueueActivity.Equals(other.TrackOnQueueActivity)
                ) &&
                (
                    this.IgnoredActivityCategories == other.IgnoredActivityCategories ||
                    this.IgnoredActivityCategories != null &&
                    this.IgnoredActivityCategories.SequenceEqual(other.IgnoredActivityCategories)
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
                
                if (this.SevereAlertThresholdMinutes != null)
                    hash = hash * 59 + this.SevereAlertThresholdMinutes.GetHashCode();
                
                if (this.AdherenceTargetPercent != null)
                    hash = hash * 59 + this.AdherenceTargetPercent.GetHashCode();
                
                if (this.AdherenceExceptionThresholdSeconds != null)
                    hash = hash * 59 + this.AdherenceExceptionThresholdSeconds.GetHashCode();
                
                if (this.NonOnQueueActivitiesEquivalent != null)
                    hash = hash * 59 + this.NonOnQueueActivitiesEquivalent.GetHashCode();
                
                if (this.TrackOnQueueActivity != null)
                    hash = hash * 59 + this.TrackOnQueueActivity.GetHashCode();
                
                if (this.IgnoredActivityCategories != null)
                    hash = hash * 59 + this.IgnoredActivityCategories.GetHashCode();
                
                return hash;
            }
        }
    }

}
