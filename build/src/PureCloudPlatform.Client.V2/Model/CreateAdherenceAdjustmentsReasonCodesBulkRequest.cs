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
    /// CreateAdherenceAdjustmentsReasonCodesBulkRequest
    /// </summary>
    [DataContract]
    public partial class CreateAdherenceAdjustmentsReasonCodesBulkRequest :  IEquatable<CreateAdherenceAdjustmentsReasonCodesBulkRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdherenceAdjustmentsReasonCodesBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAdherenceAdjustmentsReasonCodesBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdherenceAdjustmentsReasonCodesBulkRequest" /> class.
        /// </summary>
        /// <param name="ReasonCodes">The reason codes to create (required).</param>
        public CreateAdherenceAdjustmentsReasonCodesBulkRequest(List<CreateAdherenceAdjustmentsReasonCodeRequest> ReasonCodes = null)
        {
            this.ReasonCodes = ReasonCodes;
            
        }
        


        /// <summary>
        /// The reason codes to create
        /// </summary>
        /// <value>The reason codes to create</value>
        [DataMember(Name="reasonCodes", EmitDefaultValue=false)]
        public List<CreateAdherenceAdjustmentsReasonCodeRequest> ReasonCodes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAdherenceAdjustmentsReasonCodesBulkRequest {\n");

            sb.Append("  ReasonCodes: ").Append(ReasonCodes).Append("\n");
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
            return this.Equals(obj as CreateAdherenceAdjustmentsReasonCodesBulkRequest);
        }

        /// <summary>
        /// Returns true if CreateAdherenceAdjustmentsReasonCodesBulkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateAdherenceAdjustmentsReasonCodesBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAdherenceAdjustmentsReasonCodesBulkRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReasonCodes == other.ReasonCodes ||
                    this.ReasonCodes != null &&
                    this.ReasonCodes.SequenceEqual(other.ReasonCodes)
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
                if (this.ReasonCodes != null)
                    hash = hash * 59 + this.ReasonCodes.GetHashCode();

                return hash;
            }
        }
    }

}
