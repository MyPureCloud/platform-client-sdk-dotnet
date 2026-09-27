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
    /// AgentQueryAdherenceAdjustmentsRequest
    /// </summary>
    [DataContract]
    public partial class AgentQueryAdherenceAdjustmentsRequest :  IEquatable<AgentQueryAdherenceAdjustmentsRequest>
    {
        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueryAdherenceAdjustmentsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentQueryAdherenceAdjustmentsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentQueryAdherenceAdjustmentsRequest" /> class.
        /// </summary>
        /// <param name="StartDate">The start timestamp of the range to query in ISO-8601 format (required).</param>
        /// <param name="EndDate">The end timestamp of the range to query in ISO-8601 format (required).</param>
        /// <param name="ReasonCodeIds">A filter for the reason codes to include. Leave empty or omit entirely for all reason codes.</param>
        /// <param name="Statuses">A filter for which adherence adjustment statuses to include. Leave empty or omit entirely for all statuses.</param>
        public AgentQueryAdherenceAdjustmentsRequest(DateTime? StartDate = null, DateTime? EndDate = null, List<string> ReasonCodeIds = null, List<StatusesEnum> Statuses = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.ReasonCodeIds = ReasonCodeIds;
            this.Statuses = Statuses;
            
        }
        


        /// <summary>
        /// The start timestamp of the range to query in ISO-8601 format
        /// </summary>
        /// <value>The start timestamp of the range to query in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The end timestamp of the range to query in ISO-8601 format
        /// </summary>
        /// <value>The end timestamp of the range to query in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// A filter for the reason codes to include. Leave empty or omit entirely for all reason codes
        /// </summary>
        /// <value>A filter for the reason codes to include. Leave empty or omit entirely for all reason codes</value>
        [DataMember(Name="reasonCodeIds", EmitDefaultValue=false)]
        public List<string> ReasonCodeIds { get; set; }



        /// <summary>
        /// A filter for which adherence adjustment statuses to include. Leave empty or omit entirely for all statuses
        /// </summary>
        /// <value>A filter for which adherence adjustment statuses to include. Leave empty or omit entirely for all statuses</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<StatusesEnum> Statuses { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentQueryAdherenceAdjustmentsRequest {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ReasonCodeIds: ").Append(ReasonCodeIds).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
            return this.Equals(obj as AgentQueryAdherenceAdjustmentsRequest);
        }

        /// <summary>
        /// Returns true if AgentQueryAdherenceAdjustmentsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentQueryAdherenceAdjustmentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentQueryAdherenceAdjustmentsRequest other)
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
                    this.ReasonCodeIds == other.ReasonCodeIds ||
                    this.ReasonCodeIds != null &&
                    this.ReasonCodeIds.SequenceEqual(other.ReasonCodeIds)
                ) &&
                (
                    this.Statuses == other.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(other.Statuses)
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

                if (this.ReasonCodeIds != null)
                    hash = hash * 59 + this.ReasonCodeIds.GetHashCode();

                if (this.Statuses != null)
                    hash = hash * 59 + this.Statuses.GetHashCode();

                return hash;
            }
        }
    }

}
