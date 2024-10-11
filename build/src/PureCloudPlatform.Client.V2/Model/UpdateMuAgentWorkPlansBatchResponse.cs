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
    /// UpdateMuAgentWorkPlansBatchResponse
    /// </summary>
    [DataContract]
    public partial class UpdateMuAgentWorkPlansBatchResponse :  IEquatable<UpdateMuAgentWorkPlansBatchResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlansBatchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateMuAgentWorkPlansBatchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlansBatchResponse" /> class.
        /// </summary>
        /// <param name="Failures">The work plan update failures (required).</param>
        public UpdateMuAgentWorkPlansBatchResponse(List<UpdateMuAgentWorkPlanFailureResponse> Failures = null)
        {
            this.Failures = Failures;
            
        }
        


        /// <summary>
        /// The work plan update failures
        /// </summary>
        /// <value>The work plan update failures</value>
        [DataMember(Name="failures", EmitDefaultValue=false)]
        public List<UpdateMuAgentWorkPlanFailureResponse> Failures { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMuAgentWorkPlansBatchResponse {\n");

            sb.Append("  Failures: ").Append(Failures).Append("\n");
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
            return this.Equals(obj as UpdateMuAgentWorkPlansBatchResponse);
        }

        /// <summary>
        /// Returns true if UpdateMuAgentWorkPlansBatchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateMuAgentWorkPlansBatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMuAgentWorkPlansBatchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Failures == other.Failures ||
                    this.Failures != null &&
                    this.Failures.SequenceEqual(other.Failures)
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
                if (this.Failures != null)
                    hash = hash * 59 + this.Failures.GetHashCode();

                return hash;
            }
        }
    }

}
