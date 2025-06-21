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
    /// ConversationSummaryExtractedEntity
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryExtractedEntity :  IEquatable<ConversationSummaryExtractedEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryExtractedEntity" /> class.
        /// </summary>
        /// <param name="Label">The label for the extracted entity.</param>
        /// <param name="Value">The value for the extracted entity.</param>
        public ConversationSummaryExtractedEntity(string Label = null, string Value = null)
        {
            this.Label = Label;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The label for the extracted entity
        /// </summary>
        /// <value>The label for the extracted entity</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }



        /// <summary>
        /// The value for the extracted entity
        /// </summary>
        /// <value>The value for the extracted entity</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryExtractedEntity {\n");

            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(obj as ConversationSummaryExtractedEntity);
        }

        /// <summary>
        /// Returns true if ConversationSummaryExtractedEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryExtractedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryExtractedEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
