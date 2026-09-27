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
    /// UpdateAdherenceAdjustmentsBulkRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAdherenceAdjustmentsBulkRequest :  IEquatable<UpdateAdherenceAdjustmentsBulkRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAdherenceAdjustmentsBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsBulkRequest" /> class.
        /// </summary>
        /// <param name="Adjustments">The adherence adjustments to update (required).</param>
        public UpdateAdherenceAdjustmentsBulkRequest(List<UpdateAdherenceAdjustmentsBulkItem> Adjustments = null)
        {
            this.Adjustments = Adjustments;
            
        }
        


        /// <summary>
        /// The adherence adjustments to update
        /// </summary>
        /// <value>The adherence adjustments to update</value>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public List<UpdateAdherenceAdjustmentsBulkItem> Adjustments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAdherenceAdjustmentsBulkRequest {\n");

            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
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
            return this.Equals(obj as UpdateAdherenceAdjustmentsBulkRequest);
        }

        /// <summary>
        /// Returns true if UpdateAdherenceAdjustmentsBulkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAdherenceAdjustmentsBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAdherenceAdjustmentsBulkRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Adjustments == other.Adjustments ||
                    this.Adjustments != null &&
                    this.Adjustments.SequenceEqual(other.Adjustments)
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
                if (this.Adjustments != null)
                    hash = hash * 59 + this.Adjustments.GetHashCode();

                return hash;
            }
        }
    }

}
