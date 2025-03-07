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
    /// WaitlistPosition
    /// </summary>
    [DataContract]
    public partial class WaitlistPosition :  IEquatable<WaitlistPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitlistPosition" /> class.
        /// </summary>
        /// <param name="TimeOffRequest">The time off request for this wait list position.</param>
        /// <param name="TimeOffLimit">The time off limit for which time off request is waitlisted.</param>
        /// <param name="Date">The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="_WaitlistPosition">The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist.</param>
        public WaitlistPosition(TimeOffRequestReference TimeOffRequest = null, TimeOffLimitReference TimeOffLimit = null, String Date = null, int? _WaitlistPosition = null)
        {
            this.TimeOffRequest = TimeOffRequest;
            this.TimeOffLimit = TimeOffLimit;
            this.Date = Date;
            this._WaitlistPosition = _WaitlistPosition;
            
        }
        


        /// <summary>
        /// The time off request for this wait list position
        /// </summary>
        /// <value>The time off request for this wait list position</value>
        [DataMember(Name="timeOffRequest", EmitDefaultValue=false)]
        public TimeOffRequestReference TimeOffRequest { get; set; }



        /// <summary>
        /// The time off limit for which time off request is waitlisted
        /// </summary>
        /// <value>The time off limit for which time off request is waitlisted</value>
        [DataMember(Name="timeOffLimit", EmitDefaultValue=false)]
        public TimeOffLimitReference TimeOffLimit { get; set; }



        /// <summary>
        /// The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date to which this wait list position applies, as defined by the time zone of the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }



        /// <summary>
        /// The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist
        /// </summary>
        /// <value>The time off request&#39;s position in the waitlist on the date. 1 means time off is the first in the waitlist</value>
        [DataMember(Name="waitlistPosition", EmitDefaultValue=false)]
        public int? _WaitlistPosition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitlistPosition {\n");

            sb.Append("  TimeOffRequest: ").Append(TimeOffRequest).Append("\n");
            sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  _WaitlistPosition: ").Append(_WaitlistPosition).Append("\n");
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
            return this.Equals(obj as WaitlistPosition);
        }

        /// <summary>
        /// Returns true if WaitlistPosition instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitlistPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitlistPosition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffRequest == other.TimeOffRequest ||
                    this.TimeOffRequest != null &&
                    this.TimeOffRequest.Equals(other.TimeOffRequest)
                ) &&
                (
                    this.TimeOffLimit == other.TimeOffLimit ||
                    this.TimeOffLimit != null &&
                    this.TimeOffLimit.Equals(other.TimeOffLimit)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this._WaitlistPosition == other._WaitlistPosition ||
                    this._WaitlistPosition != null &&
                    this._WaitlistPosition.Equals(other._WaitlistPosition)
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
                if (this.TimeOffRequest != null)
                    hash = hash * 59 + this.TimeOffRequest.GetHashCode();

                if (this.TimeOffLimit != null)
                    hash = hash * 59 + this.TimeOffLimit.GetHashCode();

                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this._WaitlistPosition != null)
                    hash = hash * 59 + this._WaitlistPosition.GetHashCode();

                return hash;
            }
        }
    }

}
