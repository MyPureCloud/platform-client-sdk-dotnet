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
    /// ScheduleVisibilitySettingsResponse
    /// </summary>
    [DataContract]
    public partial class ScheduleVisibilitySettingsResponse :  IEquatable<ScheduleVisibilitySettingsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVisibilitySettingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleVisibilitySettingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVisibilitySettingsResponse" /> class.
        /// </summary>
        /// <param name="Enabled">Whether schedule visibility controls are enabled for this management unit (required).</param>
        /// <param name="FutureWeeks">The number of weeks into the future that agents can see schedules in this management unit. 0 means current week (required).</param>
        public ScheduleVisibilitySettingsResponse(bool? Enabled = null, int? FutureWeeks = null)
        {
            this.Enabled = Enabled;
            this.FutureWeeks = FutureWeeks;
            
        }
        


        /// <summary>
        /// Whether schedule visibility controls are enabled for this management unit
        /// </summary>
        /// <value>Whether schedule visibility controls are enabled for this management unit</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The number of weeks into the future that agents can see schedules in this management unit. 0 means current week
        /// </summary>
        /// <value>The number of weeks into the future that agents can see schedules in this management unit. 0 means current week</value>
        [DataMember(Name="futureWeeks", EmitDefaultValue=false)]
        public int? FutureWeeks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleVisibilitySettingsResponse {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FutureWeeks: ").Append(FutureWeeks).Append("\n");
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
            return this.Equals(obj as ScheduleVisibilitySettingsResponse);
        }

        /// <summary>
        /// Returns true if ScheduleVisibilitySettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleVisibilitySettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleVisibilitySettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.FutureWeeks == other.FutureWeeks ||
                    this.FutureWeeks != null &&
                    this.FutureWeeks.Equals(other.FutureWeeks)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.FutureWeeks != null)
                    hash = hash * 59 + this.FutureWeeks.GetHashCode();

                return hash;
            }
        }
    }

}
