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
    /// ScreenMonitorSettings
    /// </summary>
    [DataContract]
    public partial class ScreenMonitorSettings :  IEquatable<ScreenMonitorSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitorSettings" /> class.
        /// </summary>
        /// <param name="EnableAgentNotifications">EnableAgentNotifications.</param>
        /// <param name="MaxSimultaneousScreenMonitoringSessions">MaxSimultaneousScreenMonitoringSessions.</param>
        public ScreenMonitorSettings(bool? EnableAgentNotifications = null, int? MaxSimultaneousScreenMonitoringSessions = null)
        {
            this.EnableAgentNotifications = EnableAgentNotifications;
            this.MaxSimultaneousScreenMonitoringSessions = MaxSimultaneousScreenMonitoringSessions;
            
        }
        


        /// <summary>
        /// Gets or Sets EnableAgentNotifications
        /// </summary>
        [DataMember(Name="enableAgentNotifications", EmitDefaultValue=false)]
        public bool? EnableAgentNotifications { get; set; }



        /// <summary>
        /// Gets or Sets MaxSimultaneousScreenMonitoringSessions
        /// </summary>
        [DataMember(Name="maxSimultaneousScreenMonitoringSessions", EmitDefaultValue=false)]
        public int? MaxSimultaneousScreenMonitoringSessions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenMonitorSettings {\n");

            sb.Append("  EnableAgentNotifications: ").Append(EnableAgentNotifications).Append("\n");
            sb.Append("  MaxSimultaneousScreenMonitoringSessions: ").Append(MaxSimultaneousScreenMonitoringSessions).Append("\n");
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
            return this.Equals(obj as ScreenMonitorSettings);
        }

        /// <summary>
        /// Returns true if ScreenMonitorSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ScreenMonitorSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenMonitorSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAgentNotifications == other.EnableAgentNotifications ||
                    this.EnableAgentNotifications != null &&
                    this.EnableAgentNotifications.Equals(other.EnableAgentNotifications)
                ) &&
                (
                    this.MaxSimultaneousScreenMonitoringSessions == other.MaxSimultaneousScreenMonitoringSessions ||
                    this.MaxSimultaneousScreenMonitoringSessions != null &&
                    this.MaxSimultaneousScreenMonitoringSessions.Equals(other.MaxSimultaneousScreenMonitoringSessions)
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
                if (this.EnableAgentNotifications != null)
                    hash = hash * 59 + this.EnableAgentNotifications.GetHashCode();

                if (this.MaxSimultaneousScreenMonitoringSessions != null)
                    hash = hash * 59 + this.MaxSimultaneousScreenMonitoringSessions.GetHashCode();

                return hash;
            }
        }
    }

}
