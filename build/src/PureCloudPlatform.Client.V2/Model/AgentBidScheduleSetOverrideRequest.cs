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
    /// AgentBidScheduleSetOverrideRequest
    /// </summary>
    [DataContract]
    public partial class AgentBidScheduleSetOverrideRequest :  IEquatable<AgentBidScheduleSetOverrideRequest>
    {
        /// <summary>
        /// The reason the assigned schedule set has been overridden. This must be null if no override schedule is set
        /// </summary>
        /// <value>The reason the assigned schedule set has been overridden. This must be null if no override schedule is set</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OverrideReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unabletobid for "UnableToBid"
            /// </summary>
            [EnumMember(Value = "UnableToBid")]
            Unabletobid,
            
            /// <summary>
            /// Enum Changeofcircumstance for "ChangeOfCircumstance"
            /// </summary>
            [EnumMember(Value = "ChangeOfCircumstance")]
            Changeofcircumstance,
            
            /// <summary>
            /// Enum Newhire for "NewHire"
            /// </summary>
            [EnumMember(Value = "NewHire")]
            Newhire,
            
            /// <summary>
            /// Enum Employeemove for "EmployeeMove"
            /// </summary>
            [EnumMember(Value = "EmployeeMove")]
            Employeemove
        }
        /// <summary>
        /// The reason the assigned schedule set has been overridden. This must be null if no override schedule is set
        /// </summary>
        /// <value>The reason the assigned schedule set has been overridden. This must be null if no override schedule is set</value>
        [DataMember(Name="overrideReason", EmitDefaultValue=false)]
        public OverrideReasonEnum? OverrideReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBidScheduleSetOverrideRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentBidScheduleSetOverrideRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBidScheduleSetOverrideRequest" /> class.
        /// </summary>
        /// <param name="AgentId">The ID of the agent (required).</param>
        /// <param name="OverrideScheduleSetId">If provided, the schedule set overrides the agent&#39;s assigned schedule set.</param>
        /// <param name="OverrideReason">The reason the assigned schedule set has been overridden. This must be null if no override schedule is set.</param>
        public AgentBidScheduleSetOverrideRequest(string AgentId = null, string OverrideScheduleSetId = null, OverrideReasonEnum? OverrideReason = null)
        {
            this.AgentId = AgentId;
            this.OverrideScheduleSetId = OverrideScheduleSetId;
            this.OverrideReason = OverrideReason;
            
        }
        


        /// <summary>
        /// The ID of the agent
        /// </summary>
        /// <value>The ID of the agent</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// If provided, the schedule set overrides the agent&#39;s assigned schedule set
        /// </summary>
        /// <value>If provided, the schedule set overrides the agent&#39;s assigned schedule set</value>
        [DataMember(Name="overrideScheduleSetId", EmitDefaultValue=false)]
        public string OverrideScheduleSetId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentBidScheduleSetOverrideRequest {\n");

            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  OverrideScheduleSetId: ").Append(OverrideScheduleSetId).Append("\n");
            sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
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
            return this.Equals(obj as AgentBidScheduleSetOverrideRequest);
        }

        /// <summary>
        /// Returns true if AgentBidScheduleSetOverrideRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentBidScheduleSetOverrideRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentBidScheduleSetOverrideRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.OverrideScheduleSetId == other.OverrideScheduleSetId ||
                    this.OverrideScheduleSetId != null &&
                    this.OverrideScheduleSetId.Equals(other.OverrideScheduleSetId)
                ) &&
                (
                    this.OverrideReason == other.OverrideReason ||
                    this.OverrideReason != null &&
                    this.OverrideReason.Equals(other.OverrideReason)
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
                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.OverrideScheduleSetId != null)
                    hash = hash * 59 + this.OverrideScheduleSetId.GetHashCode();

                if (this.OverrideReason != null)
                    hash = hash * 59 + this.OverrideReason.GetHashCode();

                return hash;
            }
        }
    }

}
