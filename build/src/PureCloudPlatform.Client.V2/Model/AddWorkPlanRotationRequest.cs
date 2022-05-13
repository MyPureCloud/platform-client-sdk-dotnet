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
    /// AddWorkPlanRotationRequest
    /// </summary>
    [DataContract]
    public partial class AddWorkPlanRotationRequest :  IEquatable<AddWorkPlanRotationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkPlanRotationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddWorkPlanRotationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkPlanRotationRequest" /> class.
        /// </summary>
        /// <param name="Name">Name of this work plan rotation (required).</param>
        /// <param name="DateRange">The date range to which this work plan rotation applies (required).</param>
        /// <param name="Agents">Agents in this work plan rotation.</param>
        /// <param name="Pattern">Pattern with list of work plan IDs that rotate on a weekly basis (required).</param>
        public AddWorkPlanRotationRequest(string Name = null, DateRangeWithOptionalEnd DateRange = null, List<AddWorkPlanRotationAgentRequest> Agents = null, WorkPlanPatternRequest Pattern = null)
        {
            this.Name = Name;
            this.DateRange = DateRange;
            this.Agents = Agents;
            this.Pattern = Pattern;
            
        }
        


        /// <summary>
        /// Name of this work plan rotation
        /// </summary>
        /// <value>Name of this work plan rotation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The date range to which this work plan rotation applies
        /// </summary>
        /// <value>The date range to which this work plan rotation applies</value>
        [DataMember(Name="dateRange", EmitDefaultValue=false)]
        public DateRangeWithOptionalEnd DateRange { get; set; }



        /// <summary>
        /// Agents in this work plan rotation
        /// </summary>
        /// <value>Agents in this work plan rotation</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<AddWorkPlanRotationAgentRequest> Agents { get; set; }



        /// <summary>
        /// Pattern with list of work plan IDs that rotate on a weekly basis
        /// </summary>
        /// <value>Pattern with list of work plan IDs that rotate on a weekly basis</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public WorkPlanPatternRequest Pattern { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddWorkPlanRotationRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
            return this.Equals(obj as AddWorkPlanRotationRequest);
        }

        /// <summary>
        /// Returns true if AddWorkPlanRotationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AddWorkPlanRotationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddWorkPlanRotationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateRange == other.DateRange ||
                    this.DateRange != null &&
                    this.DateRange.Equals(other.DateRange)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.Pattern == other.Pattern ||
                    this.Pattern != null &&
                    this.Pattern.Equals(other.Pattern)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateRange != null)
                    hash = hash * 59 + this.DateRange.GetHashCode();

                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();

                if (this.Pattern != null)
                    hash = hash * 59 + this.Pattern.GetHashCode();

                return hash;
            }
        }
    }

}
