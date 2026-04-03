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
    /// UpdateShiftTradeJobRequest
    /// </summary>
    [DataContract]
    public partial class UpdateShiftTradeJobRequest :  IEquatable<UpdateShiftTradeJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftTradeJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateShiftTradeJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftTradeJobRequest" /> class.
        /// </summary>
        /// <param name="WeekDate">The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Target">Target of the shift trade, if applicable.</param>
        /// <param name="ExpirationDate">When this shift trade will expire. Date time is represented as an ISO-8601 string.</param>
        /// <param name="AcceptableIntervals">Time frames when the initiating user is willing to accept a shift in exchange. Setting the enclosed list to empty will make this a one sided trade request..</param>
        /// <param name="Metadata">Version metadata for the shift trade (required).</param>
        public UpdateShiftTradeJobRequest(String WeekDate = null, ValueWrapperShiftTradeTargetRequestItem Target = null, ValueWrapperDate ExpirationDate = null, ListWrapperRequiredDateRange AcceptableIntervals = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.WeekDate = WeekDate;
            this.Target = Target;
            this.ExpirationDate = ExpirationDate;
            this.AcceptableIntervals = AcceptableIntervals;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// Target of the shift trade, if applicable
        /// </summary>
        /// <value>Target of the shift trade, if applicable</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public ValueWrapperShiftTradeTargetRequestItem Target { get; set; }



        /// <summary>
        /// When this shift trade will expire. Date time is represented as an ISO-8601 string
        /// </summary>
        /// <value>When this shift trade will expire. Date time is represented as an ISO-8601 string</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public ValueWrapperDate ExpirationDate { get; set; }



        /// <summary>
        /// Time frames when the initiating user is willing to accept a shift in exchange. Setting the enclosed list to empty will make this a one sided trade request.
        /// </summary>
        /// <value>Time frames when the initiating user is willing to accept a shift in exchange. Setting the enclosed list to empty will make this a one sided trade request.</value>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public ListWrapperRequiredDateRange AcceptableIntervals { get; set; }



        /// <summary>
        /// Version metadata for the shift trade
        /// </summary>
        /// <value>Version metadata for the shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShiftTradeJobRequest {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as UpdateShiftTradeJobRequest);
        }

        /// <summary>
        /// Returns true if UpdateShiftTradeJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateShiftTradeJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShiftTradeJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.Equals(other.AcceptableIntervals)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();

                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
