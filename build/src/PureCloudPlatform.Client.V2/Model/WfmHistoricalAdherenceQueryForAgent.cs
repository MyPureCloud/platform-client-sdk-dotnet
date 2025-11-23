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
    /// WfmHistoricalAdherenceQueryForAgent
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceQueryForAgent :  IEquatable<WfmHistoricalAdherenceQueryForAgent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQueryForAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmHistoricalAdherenceQueryForAgent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQueryForAgent" /> class.
        /// </summary>
        /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
        /// <param name="EndDate">End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time.</param>
        /// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input..</param>
        public WfmHistoricalAdherenceQueryForAgent(DateTime? StartDate = null, DateTime? EndDate = null, string TimeZone = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TimeZone = TimeZone;
            
        }
        


        /// <summary>
        /// Beginning of the date range to query in ISO-8601 format
        /// </summary>
        /// <value>Beginning of the date range to query in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time
        /// </summary>
        /// <value>End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.
        /// </summary>
        /// <value>The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceQueryForAgent {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceQueryForAgent);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceQueryForAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceQueryForAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceQueryForAgent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                return hash;
            }
        }
    }

}
