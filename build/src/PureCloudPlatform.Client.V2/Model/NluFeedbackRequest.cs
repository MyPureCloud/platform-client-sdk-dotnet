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
    /// NluFeedbackRequest
    /// </summary>
    [DataContract]
    public partial class NluFeedbackRequest :  IEquatable<NluFeedbackRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NluFeedbackRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
        /// </summary>
        /// <param name="Text">The feedback text. (required).</param>
        /// <param name="Intents">Detected intent of the utterance (required).</param>
        /// <param name="VersionId">The domain version ID of the feedback. (required).</param>
        public NluFeedbackRequest(string Text = null, List<IntentFeedback> Intents = null, string VersionId = null)
        {
            this.Text = Text;
            this.Intents = Intents;
            this.VersionId = VersionId;
            
        }
        
        
        
        /// <summary>
        /// The feedback text.
        /// </summary>
        /// <value>The feedback text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Detected intent of the utterance
        /// </summary>
        /// <value>Detected intent of the utterance</value>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public List<IntentFeedback> Intents { get; set; }
        
        
        
        /// <summary>
        /// The domain version ID of the feedback.
        /// </summary>
        /// <value>The domain version ID of the feedback.</value>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluFeedbackRequest {\n");
            
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Intents: ").Append(Intents).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
            return this.Equals(obj as NluFeedbackRequest);
        }

        /// <summary>
        /// Returns true if NluFeedbackRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NluFeedbackRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluFeedbackRequest other)
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
                    this.Intents == other.Intents ||
                    this.Intents != null &&
                    this.Intents.SequenceEqual(other.Intents)
                ) &&
                (
                    this.VersionId == other.VersionId ||
                    this.VersionId != null &&
                    this.VersionId.Equals(other.VersionId)
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
                
                if (this.Intents != null)
                    hash = hash * 59 + this.Intents.GetHashCode();
                
                if (this.VersionId != null)
                    hash = hash * 59 + this.VersionId.GetHashCode();
                
                return hash;
            }
        }
    }

}
