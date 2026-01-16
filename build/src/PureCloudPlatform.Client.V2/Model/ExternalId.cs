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
    /// ExternalId
    /// </summary>
    [DataContract]
    public partial class ExternalId :  IEquatable<ExternalId>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalId" /> class.
        /// </summary>
        /// <param name="ExternalSource">The external source of the identifier. Max: 255 characters. Leading and trailing whitespace stripped. (required).</param>
        /// <param name="Value">The string value of the identifier. Max: 255 characters. Leading and trailing whitespace stripped. (required).</param>
        public ExternalId(ExternalSource ExternalSource = null, string Value = null)
        {
            this.ExternalSource = ExternalSource;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The external source of the identifier. Max: 255 characters. Leading and trailing whitespace stripped.
        /// </summary>
        /// <value>The external source of the identifier. Max: 255 characters. Leading and trailing whitespace stripped.</value>
        [DataMember(Name="externalSource", EmitDefaultValue=false)]
        public ExternalSource ExternalSource { get; set; }



        /// <summary>
        /// The string value of the identifier. Max: 255 characters. Leading and trailing whitespace stripped.
        /// </summary>
        /// <value>The string value of the identifier. Max: 255 characters. Leading and trailing whitespace stripped.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalId {\n");

            sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ExternalId);
        }

        /// <summary>
        /// Returns true if ExternalId instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalSource == other.ExternalSource ||
                    this.ExternalSource != null &&
                    this.ExternalSource.Equals(other.ExternalSource)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.ExternalSource != null)
                    hash = hash * 59 + this.ExternalSource.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
