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
    /// PolicyTestPayload
    /// </summary>
    [DataContract]
    public partial class PolicyTestPayload :  IEquatable<PolicyTestPayload>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTestPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyTestPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTestPayload" /> class.
        /// </summary>
        /// <param name="AttributeData">A map of attribute names to attribute type and string representation of value. All attributes returned by api/v2/authorization/policies/{policyId}/attributes are required (required).</param>
        public PolicyTestPayload(Dictionary<string, TypedAttribute> AttributeData = null)
        {
            this.AttributeData = AttributeData;
            
        }
        


        /// <summary>
        /// A map of attribute names to attribute type and string representation of value. All attributes returned by api/v2/authorization/policies/{policyId}/attributes are required
        /// </summary>
        /// <value>A map of attribute names to attribute type and string representation of value. All attributes returned by api/v2/authorization/policies/{policyId}/attributes are required</value>
        [DataMember(Name="attributeData", EmitDefaultValue=false)]
        public Dictionary<string, TypedAttribute> AttributeData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTestPayload {\n");

            sb.Append("  AttributeData: ").Append(AttributeData).Append("\n");
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
            return this.Equals(obj as PolicyTestPayload);
        }

        /// <summary>
        /// Returns true if PolicyTestPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyTestPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyTestPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AttributeData == other.AttributeData ||
                    this.AttributeData != null &&
                    this.AttributeData.SequenceEqual(other.AttributeData)
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
                if (this.AttributeData != null)
                    hash = hash * 59 + this.AttributeData.GetHashCode();

                return hash;
            }
        }
    }

}
