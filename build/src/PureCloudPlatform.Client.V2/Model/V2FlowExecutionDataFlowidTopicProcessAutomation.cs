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
    /// This contains contextual information about an invoking entity.
    /// </summary>
    [DataContract]
    public partial class V2FlowExecutionDataFlowidTopicProcessAutomation :  IEquatable<V2FlowExecutionDataFlowidTopicProcessAutomation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicProcessAutomation" /> class.
        /// </summary>
        /// <param name="TriggerId">The identifier of the process automation trigger that invoked this flow..</param>
        /// <param name="TriggerName">The name of the process automation trigger that invoked this flow..</param>
        public V2FlowExecutionDataFlowidTopicProcessAutomation(string TriggerId = null, string TriggerName = null)
        {
            this.TriggerId = TriggerId;
            this.TriggerName = TriggerName;
            
        }
        


        /// <summary>
        /// The identifier of the process automation trigger that invoked this flow.
        /// </summary>
        /// <value>The identifier of the process automation trigger that invoked this flow.</value>
        [DataMember(Name="triggerId", EmitDefaultValue=false)]
        public string TriggerId { get; set; }



        /// <summary>
        /// The name of the process automation trigger that invoked this flow.
        /// </summary>
        /// <value>The name of the process automation trigger that invoked this flow.</value>
        [DataMember(Name="triggerName", EmitDefaultValue=false)]
        public string TriggerName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicProcessAutomation {\n");

            sb.Append("  TriggerId: ").Append(TriggerId).Append("\n");
            sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicProcessAutomation);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicProcessAutomation instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicProcessAutomation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicProcessAutomation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TriggerId == other.TriggerId ||
                    this.TriggerId != null &&
                    this.TriggerId.Equals(other.TriggerId)
                ) &&
                (
                    this.TriggerName == other.TriggerName ||
                    this.TriggerName != null &&
                    this.TriggerName.Equals(other.TriggerName)
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
                if (this.TriggerId != null)
                    hash = hash * 59 + this.TriggerId.GetHashCode();

                if (this.TriggerName != null)
                    hash = hash * 59 + this.TriggerName.GetHashCode();

                return hash;
            }
        }
    }

}
