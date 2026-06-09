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
    /// EstimateAvailablePartialDayTimeOffResponse
    /// </summary>
    [DataContract]
    public partial class EstimateAvailablePartialDayTimeOffResponse :  IEquatable<EstimateAvailablePartialDayTimeOffResponse>
    {
        /// <summary>
        /// The override date type, if the partial day request overlaps with an override date
        /// </summary>
        /// <value>The override date type, if the partial day request overlaps with an override date</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OverrideDateTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Blocked for "Blocked"
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked,
            
            /// <summary>
            /// Enum Manualreview for "ManualReview"
            /// </summary>
            [EnumMember(Value = "ManualReview")]
            Manualreview
        }
        /// <summary>
        /// The override date type, if the partial day request overlaps with an override date
        /// </summary>
        /// <value>The override date type, if the partial day request overlaps with an override date</value>
        [DataMember(Name="overrideDateType", EmitDefaultValue=false)]
        public OverrideDateTypeEnum? OverrideDateType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailablePartialDayTimeOffResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateAvailablePartialDayTimeOffResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailablePartialDayTimeOffResponse" /> class.
        /// </summary>
        /// <param name="Date">Start date-time in ISO-8601 format for partial day request (required).</param>
        /// <param name="DurationMinutes">An estimation of time off request length in minutes (required).</param>
        /// <param name="PayableMinutes">An estimation of payable part of time off request in minutes (required).</param>
        /// <param name="Flexible">Whether there is flexibility for a user to choose different hours than the system estimated (required).</param>
        /// <param name="OverrideDateType">The override date type, if the partial day request overlaps with an override date.</param>
        public EstimateAvailablePartialDayTimeOffResponse(DateTime? Date = null, int? DurationMinutes = null, int? PayableMinutes = null, bool? Flexible = null, OverrideDateTypeEnum? OverrideDateType = null)
        {
            this.Date = Date;
            this.DurationMinutes = DurationMinutes;
            this.PayableMinutes = PayableMinutes;
            this.Flexible = Flexible;
            this.OverrideDateType = OverrideDateType;
            
        }
        


        /// <summary>
        /// Start date-time in ISO-8601 format for partial day request
        /// </summary>
        /// <value>Start date-time in ISO-8601 format for partial day request</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }



        /// <summary>
        /// An estimation of time off request length in minutes
        /// </summary>
        /// <value>An estimation of time off request length in minutes</value>
        [DataMember(Name="durationMinutes", EmitDefaultValue=false)]
        public int? DurationMinutes { get; set; }



        /// <summary>
        /// An estimation of payable part of time off request in minutes
        /// </summary>
        /// <value>An estimation of payable part of time off request in minutes</value>
        [DataMember(Name="payableMinutes", EmitDefaultValue=false)]
        public int? PayableMinutes { get; set; }



        /// <summary>
        /// Whether there is flexibility for a user to choose different hours than the system estimated
        /// </summary>
        /// <value>Whether there is flexibility for a user to choose different hours than the system estimated</value>
        [DataMember(Name="flexible", EmitDefaultValue=false)]
        public bool? Flexible { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateAvailablePartialDayTimeOffResponse {\n");

            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
            sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
            sb.Append("  Flexible: ").Append(Flexible).Append("\n");
            sb.Append("  OverrideDateType: ").Append(OverrideDateType).Append("\n");
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
            return this.Equals(obj as EstimateAvailablePartialDayTimeOffResponse);
        }

        /// <summary>
        /// Returns true if EstimateAvailablePartialDayTimeOffResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EstimateAvailablePartialDayTimeOffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateAvailablePartialDayTimeOffResponse other)
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
                    this.DurationMinutes == other.DurationMinutes ||
                    this.DurationMinutes != null &&
                    this.DurationMinutes.Equals(other.DurationMinutes)
                ) &&
                (
                    this.PayableMinutes == other.PayableMinutes ||
                    this.PayableMinutes != null &&
                    this.PayableMinutes.Equals(other.PayableMinutes)
                ) &&
                (
                    this.Flexible == other.Flexible ||
                    this.Flexible != null &&
                    this.Flexible.Equals(other.Flexible)
                ) &&
                (
                    this.OverrideDateType == other.OverrideDateType ||
                    this.OverrideDateType != null &&
                    this.OverrideDateType.Equals(other.OverrideDateType)
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

                if (this.DurationMinutes != null)
                    hash = hash * 59 + this.DurationMinutes.GetHashCode();

                if (this.PayableMinutes != null)
                    hash = hash * 59 + this.PayableMinutes.GetHashCode();

                if (this.Flexible != null)
                    hash = hash * 59 + this.Flexible.GetHashCode();

                if (this.OverrideDateType != null)
                    hash = hash * 59 + this.OverrideDateType.GetHashCode();

                return hash;
            }
        }
    }

}
