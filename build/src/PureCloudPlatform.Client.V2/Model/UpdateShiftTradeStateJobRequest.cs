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
    /// UpdateShiftTradeStateJobRequest
    /// </summary>
    [DataContract]
    public partial class UpdateShiftTradeStateJobRequest :  IEquatable<UpdateShiftTradeStateJobRequest>
    {
        /// <summary>
        /// The new state to set on the shift trade
        /// </summary>
        /// <value>The new state to set on the shift trade</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unmatched for "Unmatched"
            /// </summary>
            [EnumMember(Value = "Unmatched")]
            Unmatched,
            
            /// <summary>
            /// Enum Matched for "Matched"
            /// </summary>
            [EnumMember(Value = "Matched")]
            Matched,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled
        }
        /// <summary>
        /// The new state to set on the shift trade
        /// </summary>
        /// <value>The new state to set on the shift trade</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftTradeStateJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateShiftTradeStateJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShiftTradeStateJobRequest" /> class.
        /// </summary>
        /// <param name="WeekDate">The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="State">The new state to set on the shift trade (required).</param>
        /// <param name="Metadata">Version metadata for the shift trade (required).</param>
        public UpdateShiftTradeStateJobRequest(String WeekDate = null, StateEnum? State = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.WeekDate = WeekDate;
            this.State = State;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of this shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }





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
            sb.Append("class UpdateShiftTradeStateJobRequest {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as UpdateShiftTradeStateJobRequest);
        }

        /// <summary>
        /// Returns true if UpdateShiftTradeStateJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateShiftTradeStateJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShiftTradeStateJobRequest other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
