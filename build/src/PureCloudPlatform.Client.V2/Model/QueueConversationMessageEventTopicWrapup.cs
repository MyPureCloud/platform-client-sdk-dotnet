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
    /// QueueConversationMessageEventTopicWrapup
    /// </summary>
    [DataContract]
    public partial class QueueConversationMessageEventTopicWrapup :  IEquatable<QueueConversationMessageEventTopicWrapup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationMessageEventTopicWrapup" /> class.
        /// </summary>
        /// <param name="Code">The user configured wrap up code name..</param>
        /// <param name="Notes">Text entered by the agent to describe the call or disposition..</param>
        /// <param name="Tags">List of tags selected by the agent to describe the call or disposition..</param>
        /// <param name="DurationSeconds">The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally.</param>
        /// <param name="EndTime">The timestamp when the wrapup was finished..</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public QueueConversationMessageEventTopicWrapup(string Code = null, string Notes = null, List<string> Tags = null, int? DurationSeconds = null, DateTime? EndTime = null, Dictionary<string, Object> AdditionalProperties = null)
        {
            this.Code = Code;
            this.Notes = Notes;
            this.Tags = Tags;
            this.DurationSeconds = DurationSeconds;
            this.EndTime = EndTime;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        


        /// <summary>
        /// The user configured wrap up code name.
        /// </summary>
        /// <value>The user configured wrap up code name.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Text entered by the agent to describe the call or disposition.
        /// </summary>
        /// <value>Text entered by the agent to describe the call or disposition.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// List of tags selected by the agent to describe the call or disposition.
        /// </summary>
        /// <value>List of tags selected by the agent to describe the call or disposition.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally
        /// </summary>
        /// <value>The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally</value>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }



        /// <summary>
        /// The timestamp when the wrapup was finished.
        /// </summary>
        /// <value>The timestamp when the wrapup was finished.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationMessageEventTopicWrapup {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as QueueConversationMessageEventTopicWrapup);
        }

        /// <summary>
        /// Returns true if QueueConversationMessageEventTopicWrapup instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationMessageEventTopicWrapup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationMessageEventTopicWrapup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
