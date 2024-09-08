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
    /// BuScheduleNotificationsSettingsRequest
    /// </summary>
    [DataContract]
    public partial class BuScheduleNotificationsSettingsRequest :  IEquatable<BuScheduleNotificationsSettingsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuScheduleNotificationsSettingsRequest" /> class.
        /// </summary>
        /// <param name="EarlyReminderMinutes">The number of minutes prior to the scheduled event to display an early reminder notification.</param>
        /// <param name="ActivityCategorySettings">List of activity category notification settings.</param>
        public BuScheduleNotificationsSettingsRequest(int? EarlyReminderMinutes = null, List<BuScheduleNotificationsCategorySettings> ActivityCategorySettings = null)
        {
            this.EarlyReminderMinutes = EarlyReminderMinutes;
            this.ActivityCategorySettings = ActivityCategorySettings;
            
        }
        


        /// <summary>
        /// The number of minutes prior to the scheduled event to display an early reminder notification
        /// </summary>
        /// <value>The number of minutes prior to the scheduled event to display an early reminder notification</value>
        [DataMember(Name="earlyReminderMinutes", EmitDefaultValue=false)]
        public int? EarlyReminderMinutes { get; set; }



        /// <summary>
        /// List of activity category notification settings
        /// </summary>
        /// <value>List of activity category notification settings</value>
        [DataMember(Name="activityCategorySettings", EmitDefaultValue=false)]
        public List<BuScheduleNotificationsCategorySettings> ActivityCategorySettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuScheduleNotificationsSettingsRequest {\n");

            sb.Append("  EarlyReminderMinutes: ").Append(EarlyReminderMinutes).Append("\n");
            sb.Append("  ActivityCategorySettings: ").Append(ActivityCategorySettings).Append("\n");
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
            return this.Equals(obj as BuScheduleNotificationsSettingsRequest);
        }

        /// <summary>
        /// Returns true if BuScheduleNotificationsSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuScheduleNotificationsSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuScheduleNotificationsSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EarlyReminderMinutes == other.EarlyReminderMinutes ||
                    this.EarlyReminderMinutes != null &&
                    this.EarlyReminderMinutes.Equals(other.EarlyReminderMinutes)
                ) &&
                (
                    this.ActivityCategorySettings == other.ActivityCategorySettings ||
                    this.ActivityCategorySettings != null &&
                    this.ActivityCategorySettings.SequenceEqual(other.ActivityCategorySettings)
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
                if (this.EarlyReminderMinutes != null)
                    hash = hash * 59 + this.EarlyReminderMinutes.GetHashCode();

                if (this.ActivityCategorySettings != null)
                    hash = hash * 59 + this.ActivityCategorySettings.GetHashCode();

                return hash;
            }
        }
    }

}
