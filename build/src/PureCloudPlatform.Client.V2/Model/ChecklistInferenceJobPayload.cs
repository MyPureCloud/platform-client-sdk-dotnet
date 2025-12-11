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
    /// ChecklistInferenceJobPayload
    /// </summary>
    [DataContract]
    public partial class ChecklistInferenceJobPayload :  IEquatable<ChecklistInferenceJobPayload>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistInferenceJobPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChecklistInferenceJobPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistInferenceJobPayload" /> class.
        /// </summary>
        /// <param name="ConversationContext">List of conversations on which checklist evaluation is to be done. (required).</param>
        public ChecklistInferenceJobPayload(List<ConversationContext> ConversationContext = null)
        {
            this.ConversationContext = ConversationContext;
            
        }
        


        /// <summary>
        /// List of conversations on which checklist evaluation is to be done.
        /// </summary>
        /// <value>List of conversations on which checklist evaluation is to be done.</value>
        [DataMember(Name="conversationContext", EmitDefaultValue=false)]
        public List<ConversationContext> ConversationContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChecklistInferenceJobPayload {\n");

            sb.Append("  ConversationContext: ").Append(ConversationContext).Append("\n");
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
            return this.Equals(obj as ChecklistInferenceJobPayload);
        }

        /// <summary>
        /// Returns true if ChecklistInferenceJobPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistInferenceJobPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistInferenceJobPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationContext == other.ConversationContext ||
                    this.ConversationContext != null &&
                    this.ConversationContext.SequenceEqual(other.ConversationContext)
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
                if (this.ConversationContext != null)
                    hash = hash * 59 + this.ConversationContext.GetHashCode();

                return hash;
            }
        }
    }

}
