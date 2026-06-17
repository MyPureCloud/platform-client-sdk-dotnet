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
    /// ValidateDetails
    /// </summary>
    [DataContract]
    public partial class ValidateDetails :  IEquatable<ValidateDetails>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateDetails" /> class.
        /// </summary>
        /// <param name="Flow">The flow to validate. If you do not provide the flow ID, you must provide both the name and type. (required).</param>
        public ValidateDetails(ArchitectFlowReference Flow = null)
        {
            this.Flow = Flow;
            
        }
        


        /// <summary>
        /// The flow to validate. If you do not provide the flow ID, you must provide both the name and type.
        /// </summary>
        /// <value>The flow to validate. If you do not provide the flow ID, you must provide both the name and type.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public ArchitectFlowReference Flow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateDetails {\n");

            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
            return this.Equals(obj as ValidateDetails);
        }

        /// <summary>
        /// Returns true if ValidateDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
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
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                return hash;
            }
        }
    }

}
