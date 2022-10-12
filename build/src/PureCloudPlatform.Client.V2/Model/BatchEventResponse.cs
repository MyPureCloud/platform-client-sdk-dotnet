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
    /// BatchEventResponse
    /// </summary>
    [DataContract]
    public partial class BatchEventResponse :  IEquatable<BatchEventResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEventResponse" /> class.
        /// </summary>
        /// <param name="Errors">A list of validation or server errors that occurred for posted events..</param>
        public BatchEventResponse(List<EventError> Errors = null)
        {
            this.Errors = Errors;
            
        }
        


        /// <summary>
        /// A list of validation or server errors that occurred for posted events.
        /// </summary>
        /// <value>A list of validation or server errors that occurred for posted events.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<EventError> Errors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchEventResponse {\n");

            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as BatchEventResponse);
        }

        /// <summary>
        /// Returns true if BatchEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchEventResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                return hash;
            }
        }
    }

}
