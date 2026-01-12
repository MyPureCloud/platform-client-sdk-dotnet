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
    /// ValidateAgentUnavailableTimesRequest
    /// </summary>
    [DataContract]
    public partial class ValidateAgentUnavailableTimesRequest :  IEquatable<ValidateAgentUnavailableTimesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAgentUnavailableTimesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateAgentUnavailableTimesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAgentUnavailableTimesRequest" /> class.
        /// </summary>
        /// <param name="ValidationWeekDate">The ID of the week to validate. Must correspond to the start day of week of the business unit to which the agent belongs in the format YYYY-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="UnavailableTimes">Proposed changes to agent&#39;s unavailable time spans to be validated (required).</param>
        public ValidateAgentUnavailableTimesRequest(String ValidationWeekDate = null, List<UpdateUnavailableTime> UnavailableTimes = null)
        {
            this.ValidationWeekDate = ValidationWeekDate;
            this.UnavailableTimes = UnavailableTimes;
            
        }
        


        /// <summary>
        /// The ID of the week to validate. Must correspond to the start day of week of the business unit to which the agent belongs in the format YYYY-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The ID of the week to validate. Must correspond to the start day of week of the business unit to which the agent belongs in the format YYYY-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="validationWeekDate", EmitDefaultValue=false)]
        public String ValidationWeekDate { get; set; }



        /// <summary>
        /// Proposed changes to agent&#39;s unavailable time spans to be validated
        /// </summary>
        /// <value>Proposed changes to agent&#39;s unavailable time spans to be validated</value>
        [DataMember(Name="unavailableTimes", EmitDefaultValue=false)]
        public List<UpdateUnavailableTime> UnavailableTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAgentUnavailableTimesRequest {\n");

            sb.Append("  ValidationWeekDate: ").Append(ValidationWeekDate).Append("\n");
            sb.Append("  UnavailableTimes: ").Append(UnavailableTimes).Append("\n");
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
            return this.Equals(obj as ValidateAgentUnavailableTimesRequest);
        }

        /// <summary>
        /// Returns true if ValidateAgentUnavailableTimesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateAgentUnavailableTimesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateAgentUnavailableTimesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ValidationWeekDate == other.ValidationWeekDate ||
                    this.ValidationWeekDate != null &&
                    this.ValidationWeekDate.Equals(other.ValidationWeekDate)
                ) &&
                (
                    this.UnavailableTimes == other.UnavailableTimes ||
                    this.UnavailableTimes != null &&
                    this.UnavailableTimes.SequenceEqual(other.UnavailableTimes)
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
                if (this.ValidationWeekDate != null)
                    hash = hash * 59 + this.ValidationWeekDate.GetHashCode();

                if (this.UnavailableTimes != null)
                    hash = hash * 59 + this.UnavailableTimes.GetHashCode();

                return hash;
            }
        }
    }

}
