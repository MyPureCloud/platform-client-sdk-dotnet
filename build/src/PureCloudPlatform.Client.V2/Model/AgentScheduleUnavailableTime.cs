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
    /// AgentScheduleUnavailableTime
    /// </summary>
    [DataContract]
    public partial class AgentScheduleUnavailableTime :  IEquatable<AgentScheduleUnavailableTime>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleUnavailableTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentScheduleUnavailableTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleUnavailableTime" /> class.
        /// </summary>
        /// <param name="TimeSpan">Exact date, time and length of the unavailability time span (required).</param>
        /// <param name="Notes">Comments explaining the unavailability time span.</param>
        public AgentScheduleUnavailableTime(UnavailableTimesTimeSpan TimeSpan = null, string Notes = null)
        {
            this.TimeSpan = TimeSpan;
            this.Notes = Notes;
            
        }
        


        /// <summary>
        /// Exact date, time and length of the unavailability time span
        /// </summary>
        /// <value>Exact date, time and length of the unavailability time span</value>
        [DataMember(Name="timeSpan", EmitDefaultValue=false)]
        public UnavailableTimesTimeSpan TimeSpan { get; set; }



        /// <summary>
        /// Comments explaining the unavailability time span
        /// </summary>
        /// <value>Comments explaining the unavailability time span</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentScheduleUnavailableTime {\n");

            sb.Append("  TimeSpan: ").Append(TimeSpan).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as AgentScheduleUnavailableTime);
        }

        /// <summary>
        /// Returns true if AgentScheduleUnavailableTime instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentScheduleUnavailableTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentScheduleUnavailableTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeSpan == other.TimeSpan ||
                    this.TimeSpan != null &&
                    this.TimeSpan.Equals(other.TimeSpan)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                if (this.TimeSpan != null)
                    hash = hash * 59 + this.TimeSpan.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                return hash;
            }
        }
    }

}
