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
    /// ConversationSummaryResolution
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryResolution :  IEquatable<ConversationSummaryResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryResolution" /> class.
        /// </summary>
        /// <param name="Confidence">The AI confidence value..</param>
        /// <param name="Text">The text of the resolution..</param>
        /// <param name="Description">The description..</param>
        /// <param name="Outcome">The outcome of the conversation&#39;s resolution..</param>
        public ConversationSummaryResolution(float? Confidence = null, string Text = null, string Description = null, string Outcome = null)
        {
            this.Confidence = Confidence;
            this.Text = Text;
            this.Description = Description;
            this.Outcome = Outcome;
            
        }
        


        /// <summary>
        /// The AI confidence value.
        /// </summary>
        /// <value>The AI confidence value.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public float? Confidence { get; set; }



        /// <summary>
        /// The text of the resolution.
        /// </summary>
        /// <value>The text of the resolution.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The outcome of the conversation&#39;s resolution.
        /// </summary>
        /// <value>The outcome of the conversation&#39;s resolution.</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public string Outcome { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryResolution {\n");

            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
            return this.Equals(obj as ConversationSummaryResolution);
        }

        /// <summary>
        /// Returns true if ConversationSummaryResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryResolution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();

                return hash;
            }
        }
    }

}
