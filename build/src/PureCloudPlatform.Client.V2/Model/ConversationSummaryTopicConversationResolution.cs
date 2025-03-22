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
    /// ConversationSummaryTopicConversationResolution
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTopicConversationResolution :  IEquatable<ConversationSummaryTopicConversationResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTopicConversationResolution" /> class.
        /// </summary>
        /// <param name="Text">Text.</param>
        /// <param name="Description">Description.</param>
        /// <param name="ResolutionValue">ResolutionValue.</param>
        /// <param name="Score">Score.</param>
        public ConversationSummaryTopicConversationResolution(string Text = null, string Description = null, string ResolutionValue = null, double? Score = null)
        {
            this.Text = Text;
            this.Description = Description;
            this.ResolutionValue = ResolutionValue;
            this.Score = Score;
            
        }
        


        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets ResolutionValue
        /// </summary>
        [DataMember(Name="resolutionValue", EmitDefaultValue=false)]
        public string ResolutionValue { get; set; }



        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryTopicConversationResolution {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ResolutionValue: ").Append(ResolutionValue).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as ConversationSummaryTopicConversationResolution);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTopicConversationResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTopicConversationResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTopicConversationResolution other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ResolutionValue == other.ResolutionValue ||
                    this.ResolutionValue != null &&
                    this.ResolutionValue.Equals(other.ResolutionValue)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ResolutionValue != null)
                    hash = hash * 59 + this.ResolutionValue.GetHashCode();

                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();

                return hash;
            }
        }
    }

}
