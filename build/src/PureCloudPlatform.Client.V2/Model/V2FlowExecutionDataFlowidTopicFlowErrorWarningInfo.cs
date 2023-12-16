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
    /// V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo
    /// </summary>
    [DataContract]
    public partial class V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo :  IEquatable<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo" /> class.
        /// </summary>
        /// <param name="Reason">The reason a executionItem encountered an error or warning..</param>
        /// <param name="ExecutionId">If applicable, the executionId for the executionItem that invoked the error or warning..</param>
        /// <param name="ObjectId">If applicable, the objectId for the executionItem that invoked the error or warning..</param>
        public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo(string Reason = null, string ExecutionId = null, string ObjectId = null)
        {
            this.Reason = Reason;
            this.ExecutionId = ExecutionId;
            this.ObjectId = ObjectId;
            
        }
        


        /// <summary>
        /// The reason a executionItem encountered an error or warning.
        /// </summary>
        /// <value>The reason a executionItem encountered an error or warning.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }



        /// <summary>
        /// If applicable, the executionId for the executionItem that invoked the error or warning.
        /// </summary>
        /// <value>If applicable, the executionId for the executionItem that invoked the error or warning.</value>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }



        /// <summary>
        /// If applicable, the objectId for the executionItem that invoked the error or warning.
        /// </summary>
        /// <value>If applicable, the objectId for the executionItem that invoked the error or warning.</value>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo {\n");

            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.ExecutionId == other.ExecutionId ||
                    this.ExecutionId != null &&
                    this.ExecutionId.Equals(other.ExecutionId)
                ) &&
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.ExecutionId != null)
                    hash = hash * 59 + this.ExecutionId.GetHashCode();

                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();

                return hash;
            }
        }
    }

}
