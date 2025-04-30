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
    public partial class V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext :  IEquatable<V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext" /> class.
        /// </summary>
        /// <param name="ActionMapId">The identifier of the journey action map that invoked this flow..</param>
        /// <param name="ActionId">The identifier of the specific action map instance that invoked this flow..</param>
        public V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext(string ActionMapId = null, string ActionId = null)
        {
            this.ActionMapId = ActionMapId;
            this.ActionId = ActionId;
            
        }
        


        /// <summary>
        /// The identifier of the journey action map that invoked this flow.
        /// </summary>
        /// <value>The identifier of the journey action map that invoked this flow.</value>
        [DataMember(Name="actionMapId", EmitDefaultValue=false)]
        public string ActionMapId { get; set; }



        /// <summary>
        /// The identifier of the specific action map instance that invoked this flow.
        /// </summary>
        /// <value>The identifier of the specific action map instance that invoked this flow.</value>
        [DataMember(Name="actionId", EmitDefaultValue=false)]
        public string ActionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext {\n");

            sb.Append("  ActionMapId: ").Append(ActionMapId).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicInvokingJourneyActionMapContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActionMapId == other.ActionMapId ||
                    this.ActionMapId != null &&
                    this.ActionMapId.Equals(other.ActionMapId)
                ) &&
                (
                    this.ActionId == other.ActionId ||
                    this.ActionId != null &&
                    this.ActionId.Equals(other.ActionId)
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
                if (this.ActionMapId != null)
                    hash = hash * 59 + this.ActionMapId.GetHashCode();

                if (this.ActionId != null)
                    hash = hash * 59 + this.ActionId.GetHashCode();

                return hash;
            }
        }
    }

}
