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
    /// HeaderEntry
    /// </summary>
    [DataContract]
    public partial class HeaderEntry :  IEquatable<HeaderEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderEntry" /> class.
        /// </summary>
        /// <param name="Key">The key of the header (e.g., &#39;Subject&#39;, &#39;From&#39;, &#39;X-Custom-Header&#39;)..</param>
        /// <param name="Value">The value of the header..</param>
        public HeaderEntry(string Key = null, string Value = null)
        {
            this.Key = Key;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The key of the header (e.g., &#39;Subject&#39;, &#39;From&#39;, &#39;X-Custom-Header&#39;).
        /// </summary>
        /// <value>The key of the header (e.g., &#39;Subject&#39;, &#39;From&#39;, &#39;X-Custom-Header&#39;).</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }



        /// <summary>
        /// The value of the header.
        /// </summary>
        /// <value>The value of the header.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeaderEntry {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(obj as HeaderEntry);
        }

        /// <summary>
        /// Returns true if HeaderEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of HeaderEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeaderEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
