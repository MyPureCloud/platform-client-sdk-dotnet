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
    /// Flow Outcome data related to a bot flow which is exiting gracefully.
    /// </summary>
    [DataContract]
    public partial class TextBotFlowOutcome :  IEquatable<TextBotFlowOutcome>
    {
        
        
        
        
        
        /// <summary>
        /// The value of the FlowOutcome.
        /// </summary>
        /// <value>The value of the FlowOutcome.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OutcomeValueEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The value of the FlowOutcome.
        /// </summary>
        /// <value>The value of the FlowOutcome.</value>
        [DataMember(Name="outcomeValue", EmitDefaultValue=false)]
        public OutcomeValueEnum? OutcomeValue { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowOutcome" /> class.
        /// </summary>
        /// <param name="OutcomeId">The Flow Outcome ID..</param>
        /// <param name="OutcomeValue">The value of the FlowOutcome..</param>
        /// <param name="DateStart">The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateEnd">The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Milestones">The Flow Milestones for the Flow Outcome..</param>
        public TextBotFlowOutcome(string OutcomeId = null, OutcomeValueEnum? OutcomeValue = null, DateTime? DateStart = null, DateTime? DateEnd = null, List<TextBotFlowMilestone> Milestones = null)
        {
            this.OutcomeId = OutcomeId;
            this.OutcomeValue = OutcomeValue;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Milestones = Milestones;
            
        }
        
        
        
        /// <summary>
        /// The Flow Outcome ID.
        /// </summary>
        /// <value>The Flow Outcome ID.</value>
        [DataMember(Name="outcomeId", EmitDefaultValue=false)]
        public string OutcomeId { get; set; }
        
        
        
        
        
        /// <summary>
        /// The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp for when the Flow Outcome began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }
        
        
        
        /// <summary>
        /// The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp for when the Flow Outcome finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }
        
        
        
        /// <summary>
        /// The Flow Milestones for the Flow Outcome.
        /// </summary>
        /// <value>The Flow Milestones for the Flow Outcome.</value>
        [DataMember(Name="milestones", EmitDefaultValue=false)]
        public List<TextBotFlowMilestone> Milestones { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotFlowOutcome {\n");
            
            sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
            sb.Append("  OutcomeValue: ").Append(OutcomeValue).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Milestones: ").Append(Milestones).Append("\n");
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
            return this.Equals(obj as TextBotFlowOutcome);
        }

        /// <summary>
        /// Returns true if TextBotFlowOutcome instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotFlowOutcome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotFlowOutcome other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OutcomeId == other.OutcomeId ||
                    this.OutcomeId != null &&
                    this.OutcomeId.Equals(other.OutcomeId)
                ) &&
                (
                    this.OutcomeValue == other.OutcomeValue ||
                    this.OutcomeValue != null &&
                    this.OutcomeValue.Equals(other.OutcomeValue)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.Milestones == other.Milestones ||
                    this.Milestones != null &&
                    this.Milestones.SequenceEqual(other.Milestones)
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
                
                if (this.OutcomeId != null)
                    hash = hash * 59 + this.OutcomeId.GetHashCode();
                
                if (this.OutcomeValue != null)
                    hash = hash * 59 + this.OutcomeValue.GetHashCode();
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();
                
                if (this.Milestones != null)
                    hash = hash * 59 + this.Milestones.GetHashCode();
                
                return hash;
            }
        }
    }

}
