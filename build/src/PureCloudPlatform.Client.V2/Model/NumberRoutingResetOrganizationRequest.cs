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
    /// Number Routing reset routing request body
    /// </summary>
    [DataContract]
    public partial class NumberRoutingResetOrganizationRequest :  IEquatable<NumberRoutingResetOrganizationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberRoutingResetOrganizationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumberRoutingResetOrganizationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberRoutingResetOrganizationRequest" /> class.
        /// </summary>
        /// <param name="ResetOrganizationId">Organization Id where all rerouted numbers will be reset to (required).</param>
        public NumberRoutingResetOrganizationRequest(string ResetOrganizationId = null)
        {
            this.ResetOrganizationId = ResetOrganizationId;
            
        }
        


        /// <summary>
        /// Organization Id where all rerouted numbers will be reset to
        /// </summary>
        /// <value>Organization Id where all rerouted numbers will be reset to</value>
        [DataMember(Name="resetOrganizationId", EmitDefaultValue=false)]
        public string ResetOrganizationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberRoutingResetOrganizationRequest {\n");

            sb.Append("  ResetOrganizationId: ").Append(ResetOrganizationId).Append("\n");
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
            return this.Equals(obj as NumberRoutingResetOrganizationRequest);
        }

        /// <summary>
        /// Returns true if NumberRoutingResetOrganizationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberRoutingResetOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberRoutingResetOrganizationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ResetOrganizationId == other.ResetOrganizationId ||
                    this.ResetOrganizationId != null &&
                    this.ResetOrganizationId.Equals(other.ResetOrganizationId)
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
                if (this.ResetOrganizationId != null)
                    hash = hash * 59 + this.ResetOrganizationId.GetHashCode();

                return hash;
            }
        }
    }

}
