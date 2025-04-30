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
    /// This contains information about the workitem that invoked this flow execution.
    /// </summary>
    [DataContract]
    public partial class V2FlowExecutionDataFlowidTopicInvokingWorkitemContext :  IEquatable<V2FlowExecutionDataFlowidTopicInvokingWorkitemContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingWorkitemContext" /> class.
        /// </summary>
        /// <param name="WorkitemId">The identifier of the workitem that invoked this flow..</param>
        /// <param name="WorkitemName">The name of the process workitem that invoked this flow..</param>
        public V2FlowExecutionDataFlowidTopicInvokingWorkitemContext(string WorkitemId = null, string WorkitemName = null)
        {
            this.WorkitemId = WorkitemId;
            this.WorkitemName = WorkitemName;
            
        }
        


        /// <summary>
        /// The identifier of the workitem that invoked this flow.
        /// </summary>
        /// <value>The identifier of the workitem that invoked this flow.</value>
        [DataMember(Name="workitemId", EmitDefaultValue=false)]
        public string WorkitemId { get; set; }



        /// <summary>
        /// The name of the process workitem that invoked this flow.
        /// </summary>
        /// <value>The name of the process workitem that invoked this flow.</value>
        [DataMember(Name="workitemName", EmitDefaultValue=false)]
        public string WorkitemName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicInvokingWorkitemContext {\n");

            sb.Append("  WorkitemId: ").Append(WorkitemId).Append("\n");
            sb.Append("  WorkitemName: ").Append(WorkitemName).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicInvokingWorkitemContext);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicInvokingWorkitemContext instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingWorkitemContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicInvokingWorkitemContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkitemId == other.WorkitemId ||
                    this.WorkitemId != null &&
                    this.WorkitemId.Equals(other.WorkitemId)
                ) &&
                (
                    this.WorkitemName == other.WorkitemName ||
                    this.WorkitemName != null &&
                    this.WorkitemName.Equals(other.WorkitemName)
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
                if (this.WorkitemId != null)
                    hash = hash * 59 + this.WorkitemId.GetHashCode();

                if (this.WorkitemName != null)
                    hash = hash * 59 + this.WorkitemName.GetHashCode();

                return hash;
            }
        }
    }

}
