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
    /// UpdateWorkPlanRotationAgentRequest
    /// </summary>
    [DataContract]
    public partial class UpdateWorkPlanRotationAgentRequest :  IEquatable<UpdateWorkPlanRotationAgentRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkPlanRotationAgentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateWorkPlanRotationAgentRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkPlanRotationAgentRequest" /> class.
        /// </summary>
        /// <param name="UserId">The ID of an agent in this work plan rotation (required).</param>
        /// <param name="DateRange">The date range to which this agent is effective in the work plan rotation.</param>
        /// <param name="Position">Start position of the work plan in the pattern for this agent in the work plan rotation. Position value starts from 0.</param>
        /// <param name="Delete">If marked true for this agent when updating, then this agent will be removed from this work plan rotation.</param>
        public UpdateWorkPlanRotationAgentRequest(string UserId = null, DateRangeWithOptionalEnd DateRange = null, int? Position = null, bool? Delete = null)
        {
            this.UserId = UserId;
            this.DateRange = DateRange;
            this.Position = Position;
            this.Delete = Delete;
            
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
        /// If marked true for this agent when updating, then this agent will be removed from this work plan rotation
        /// </summary>
        /// <value>If marked true for this agent when updating, then this agent will be removed from this work plan rotation</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWorkPlanRotationAgentRequest {\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(obj as UpdateWorkPlanRotationAgentRequest);
        }

        /// <summary>
        /// Returns true if UpdateWorkPlanRotationAgentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateWorkPlanRotationAgentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWorkPlanRotationAgentRequest other)
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
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
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
                
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                
                return hash;
            }
        }
    }

}
