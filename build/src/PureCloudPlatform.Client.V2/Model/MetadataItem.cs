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
    /// MetadataItem
    /// </summary>
    [DataContract]
    public partial class MetadataItem :  IEquatable<MetadataItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataItem" /> class.
        /// </summary>
        /// <param name="Text">The text contents of the metadata.</param>
        /// <param name="Attributes">The custom attributes for the metadata.</param>
        public MetadataItem(string Text = null, Dictionary<string, string> Attributes = null)
        {
            this.Text = Text;
            this.Attributes = Attributes;
            
        }
        


        /// <summary>
        /// The text contents of the metadata
        /// </summary>
        /// <value>The text contents of the metadata</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The custom attributes for the metadata
        /// </summary>
        /// <value>The custom attributes for the metadata</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataItem {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as MetadataItem);
        }

        /// <summary>
        /// Returns true if MetadataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of MetadataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }
    }

}
