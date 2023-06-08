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
    /// OutcomeAttributionAsyncResponse
    /// </summary>
    [DataContract]
    public partial class OutcomeAttributionAsyncResponse :  IEquatable<OutcomeAttributionAsyncResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeAttributionAsyncResponse" /> class.
        /// </summary>
        /// <param name="PercentFailedThreshold">Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100..</param>
        public OutcomeAttributionAsyncResponse(int? PercentFailedThreshold = null)
        {
            this.PercentFailedThreshold = PercentFailedThreshold;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.
        /// </summary>
        /// <value>Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.</value>
        [DataMember(Name="percentFailedThreshold", EmitDefaultValue=false)]
        public int? PercentFailedThreshold { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeAttributionAsyncResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PercentFailedThreshold: ").Append(PercentFailedThreshold).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as OutcomeAttributionAsyncResponse);
        }

        /// <summary>
        /// Returns true if OutcomeAttributionAsyncResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OutcomeAttributionAsyncResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeAttributionAsyncResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.PercentFailedThreshold == other.PercentFailedThreshold ||
                    this.PercentFailedThreshold != null &&
                    this.PercentFailedThreshold.Equals(other.PercentFailedThreshold)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.PercentFailedThreshold != null)
                    hash = hash * 59 + this.PercentFailedThreshold.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
