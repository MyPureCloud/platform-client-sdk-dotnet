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
    /// ConversationSummaryTopicVirtualAgentsConversationResolution
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTopicVirtualAgentsConversationResolution :  IEquatable<ConversationSummaryTopicVirtualAgentsConversationResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationResolution" /> class.
        /// </summary>
        /// <param name="Text">Text.</param>
        /// <param name="Description">Description.</param>
        /// <param name="ResolutionValue">ResolutionValue.</param>
        /// <param name="Score">Score.</param>
        public ConversationSummaryTopicVirtualAgentsConversationResolution(string Text = null, string Description = null, string ResolutionValue = null, double? Score = null)
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
            sb.Append("class ConversationSummaryTopicVirtualAgentsConversationResolution {\n");

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
            return this.Equals(obj as ConversationSummaryTopicVirtualAgentsConversationResolution);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTopicVirtualAgentsConversationResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTopicVirtualAgentsConversationResolution other)
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
