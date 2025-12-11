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
    /// AgentActionPayload
    /// </summary>
    [DataContract]
    public partial class AgentActionPayload :  IEquatable<AgentActionPayload>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentActionPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentActionPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentActionPayload" /> class.
        /// </summary>
        /// <param name="AfterCallWork">Boolean flag to indicate if the agent action is in ACW stage..</param>
        /// <param name="ChecklistItems">The list of checklist items and the agent action taken on each one of them. (required).</param>
        public AgentActionPayload(bool? AfterCallWork = null, List<AgentAction> ChecklistItems = null)
        {
            this.AfterCallWork = AfterCallWork;
            this.ChecklistItems = ChecklistItems;
            
        }
        


        /// <summary>
        /// Boolean flag to indicate if the agent action is in ACW stage.
        /// </summary>
        /// <value>Boolean flag to indicate if the agent action is in ACW stage.</value>
        [DataMember(Name="afterCallWork", EmitDefaultValue=false)]
        public bool? AfterCallWork { get; set; }



        /// <summary>
        /// The list of checklist items and the agent action taken on each one of them.
        /// </summary>
        /// <value>The list of checklist items and the agent action taken on each one of them.</value>
        [DataMember(Name="checklistItems", EmitDefaultValue=false)]
        public List<AgentAction> ChecklistItems { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentActionPayload {\n");

            sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
            sb.Append("  ChecklistItems: ").Append(ChecklistItems).Append("\n");
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
            return this.Equals(obj as AgentActionPayload);
        }

        /// <summary>
        /// Returns true if AgentActionPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentActionPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentActionPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AfterCallWork == other.AfterCallWork ||
                    this.AfterCallWork != null &&
                    this.AfterCallWork.Equals(other.AfterCallWork)
                ) &&
                (
                    this.ChecklistItems == other.ChecklistItems ||
                    this.ChecklistItems != null &&
                    this.ChecklistItems.SequenceEqual(other.ChecklistItems)
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
                if (this.AfterCallWork != null)
                    hash = hash * 59 + this.AfterCallWork.GetHashCode();

                if (this.ChecklistItems != null)
                    hash = hash * 59 + this.ChecklistItems.GetHashCode();

                return hash;
            }
        }
    }

}
