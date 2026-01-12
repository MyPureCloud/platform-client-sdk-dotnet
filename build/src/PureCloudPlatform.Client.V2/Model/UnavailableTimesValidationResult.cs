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
    /// UnavailableTimesValidationResult
    /// </summary>
    [DataContract]
    public partial class UnavailableTimesValidationResult :  IEquatable<UnavailableTimesValidationResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesValidationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnavailableTimesValidationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnavailableTimesValidationResult" /> class.
        /// </summary>
        /// <param name="Valid">Indicates whether there are no violations in the given unavailable times (required).</param>
        /// <param name="InvalidWorkPlans">Invalid work plans that were used when validating the agents unavailable times (required).</param>
        /// <param name="WorkPlanConstraintsViolationMessage">Message for set of agent unavailable times violating work plan constraints.</param>
        public UnavailableTimesValidationResult(bool? Valid = null, List<WorkPlanReference> InvalidWorkPlans = null, WorkPlanConstraintsViolationMessage WorkPlanConstraintsViolationMessage = null)
        {
            this.Valid = Valid;
            this.InvalidWorkPlans = InvalidWorkPlans;
            this.WorkPlanConstraintsViolationMessage = WorkPlanConstraintsViolationMessage;
            
        }
        


        /// <summary>
        /// Indicates whether there are no violations in the given unavailable times
        /// </summary>
        /// <value>Indicates whether there are no violations in the given unavailable times</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }



        /// <summary>
        /// Invalid work plans that were used when validating the agents unavailable times
        /// </summary>
        /// <value>Invalid work plans that were used when validating the agents unavailable times</value>
        [DataMember(Name="invalidWorkPlans", EmitDefaultValue=false)]
        public List<WorkPlanReference> InvalidWorkPlans { get; set; }



        /// <summary>
        /// Message for set of agent unavailable times violating work plan constraints
        /// </summary>
        /// <value>Message for set of agent unavailable times violating work plan constraints</value>
        [DataMember(Name="workPlanConstraintsViolationMessage", EmitDefaultValue=false)]
        public WorkPlanConstraintsViolationMessage WorkPlanConstraintsViolationMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnavailableTimesValidationResult {\n");

            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  InvalidWorkPlans: ").Append(InvalidWorkPlans).Append("\n");
            sb.Append("  WorkPlanConstraintsViolationMessage: ").Append(WorkPlanConstraintsViolationMessage).Append("\n");
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
            return this.Equals(obj as UnavailableTimesValidationResult);
        }

        /// <summary>
        /// Returns true if UnavailableTimesValidationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of UnavailableTimesValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnavailableTimesValidationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) &&
                (
                    this.InvalidWorkPlans == other.InvalidWorkPlans ||
                    this.InvalidWorkPlans != null &&
                    this.InvalidWorkPlans.SequenceEqual(other.InvalidWorkPlans)
                ) &&
                (
                    this.WorkPlanConstraintsViolationMessage == other.WorkPlanConstraintsViolationMessage ||
                    this.WorkPlanConstraintsViolationMessage != null &&
                    this.WorkPlanConstraintsViolationMessage.Equals(other.WorkPlanConstraintsViolationMessage)
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
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();

                if (this.InvalidWorkPlans != null)
                    hash = hash * 59 + this.InvalidWorkPlans.GetHashCode();

                if (this.WorkPlanConstraintsViolationMessage != null)
                    hash = hash * 59 + this.WorkPlanConstraintsViolationMessage.GetHashCode();

                return hash;
            }
        }
    }

}
