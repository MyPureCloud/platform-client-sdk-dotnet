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
    /// AddWorkPlanRotationAgentRequest
    /// </summary>
    [DataContract]
    public partial class AddWorkPlanRotationAgentRequest :  IEquatable<AddWorkPlanRotationAgentRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkPlanRotationAgentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddWorkPlanRotationAgentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkPlanRotationAgentRequest" /> class.
        /// </summary>
        /// <param name="UserId">The ID of an agent in this work plan rotation (required).</param>
        /// <param name="DateRange">The date range to which this agent is effective in the work plan rotation (required).</param>
        /// <param name="Position">Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0 (required).</param>
        public AddWorkPlanRotationAgentRequest(string UserId = null, DateRangeWithOptionalEnd DateRange = null, int? Position = null)
        {
            this.UserId = UserId;
            this.DateRange = DateRange;
            this.Position = Position;
            
        }
        


        /// <summary>
        /// The ID of an agent in this work plan rotation
        /// </summary>
        /// <value>The ID of an agent in this work plan rotation</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// The date range to which this agent is effective in the work plan rotation
        /// </summary>
        /// <value>The date range to which this agent is effective in the work plan rotation</value>
        [DataMember(Name="dateRange", EmitDefaultValue=false)]
        public DateRangeWithOptionalEnd DateRange { get; set; }



        /// <summary>
        /// Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0
        /// </summary>
        /// <value>Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddWorkPlanRotationAgentRequest {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(obj as AddWorkPlanRotationAgentRequest);
        }

        /// <summary>
        /// Returns true if AddWorkPlanRotationAgentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AddWorkPlanRotationAgentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddWorkPlanRotationAgentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.DateRange == other.DateRange ||
                    this.DateRange != null &&
                    this.DateRange.Equals(other.DateRange)
                ) &&
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.DateRange != null)
                    hash = hash * 59 + this.DateRange.GetHashCode();

                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();

                return hash;
            }
        }
    }

}
