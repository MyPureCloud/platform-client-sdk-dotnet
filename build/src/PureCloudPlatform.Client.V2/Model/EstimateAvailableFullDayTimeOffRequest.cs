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
    /// EstimateAvailableFullDayTimeOffRequest
    /// </summary>
    [DataContract]
    public partial class EstimateAvailableFullDayTimeOffRequest :  IEquatable<EstimateAvailableFullDayTimeOffRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateAvailableFullDayTimeOffRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffRequest" /> class.
        /// </summary>
        /// <param name="Date">Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit's configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="RequestedDurationMinutes">A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting.</param>
        public EstimateAvailableFullDayTimeOffRequest(String Date = null, int? RequestedDurationMinutes = null)
        {
            this.Date = Date;
            this.RequestedDurationMinutes = RequestedDurationMinutes;
            
        }
        


        /// <summary>
        /// Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit's configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit's configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }



        /// <summary>
        /// A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting
        /// </summary>
        /// <value>A requested length of time off request in minutes. If the value is null, then the system will use activity code length setting</value>
        [DataMember(Name="requestedDurationMinutes", EmitDefaultValue=false)]
        public int? RequestedDurationMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateAvailableFullDayTimeOffRequest {\n");

            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  RequestedDurationMinutes: ").Append(RequestedDurationMinutes).Append("\n");
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
            return this.Equals(obj as EstimateAvailableFullDayTimeOffRequest);
        }

        /// <summary>
        /// Returns true if EstimateAvailableFullDayTimeOffRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EstimateAvailableFullDayTimeOffRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateAvailableFullDayTimeOffRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.RequestedDurationMinutes == other.RequestedDurationMinutes ||
                    this.RequestedDurationMinutes != null &&
                    this.RequestedDurationMinutes.Equals(other.RequestedDurationMinutes)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this.RequestedDurationMinutes != null)
                    hash = hash * 59 + this.RequestedDurationMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
