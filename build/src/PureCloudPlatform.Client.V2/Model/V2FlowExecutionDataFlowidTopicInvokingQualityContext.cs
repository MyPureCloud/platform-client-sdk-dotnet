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
    /// The quality context that invoked this.
    /// </summary>
    [DataContract]
    public partial class V2FlowExecutionDataFlowidTopicInvokingQualityContext :  IEquatable<V2FlowExecutionDataFlowidTopicInvokingQualityContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingQualityContext" /> class.
        /// </summary>
        /// <param name="PolicyId">The identifier of the quality policy that invoked this flow..</param>
        /// <param name="PolicyName">The name of the quality policy that invoked this flow..</param>
        public V2FlowExecutionDataFlowidTopicInvokingQualityContext(string PolicyId = null, string PolicyName = null)
        {
            this.PolicyId = PolicyId;
            this.PolicyName = PolicyName;
            
        }
        


        /// <summary>
        /// The identifier of the quality policy that invoked this flow.
        /// </summary>
        /// <value>The identifier of the quality policy that invoked this flow.</value>
        [DataMember(Name="policyId", EmitDefaultValue=false)]
        public string PolicyId { get; set; }



        /// <summary>
        /// The name of the quality policy that invoked this flow.
        /// </summary>
        /// <value>The name of the quality policy that invoked this flow.</value>
        [DataMember(Name="policyName", EmitDefaultValue=false)]
        public string PolicyName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2FlowExecutionDataFlowidTopicInvokingQualityContext {\n");

            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
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
            return this.Equals(obj as V2FlowExecutionDataFlowidTopicInvokingQualityContext);
        }

        /// <summary>
        /// Returns true if V2FlowExecutionDataFlowidTopicInvokingQualityContext instances are equal
        /// </summary>
        /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingQualityContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2FlowExecutionDataFlowidTopicInvokingQualityContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PolicyId == other.PolicyId ||
                    this.PolicyId != null &&
                    this.PolicyId.Equals(other.PolicyId)
                ) &&
                (
                    this.PolicyName == other.PolicyName ||
                    this.PolicyName != null &&
                    this.PolicyName.Equals(other.PolicyName)
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
                if (this.PolicyId != null)
                    hash = hash * 59 + this.PolicyId.GetHashCode();

                if (this.PolicyName != null)
                    hash = hash * 59 + this.PolicyName.GetHashCode();

                return hash;
            }
        }
    }

}
