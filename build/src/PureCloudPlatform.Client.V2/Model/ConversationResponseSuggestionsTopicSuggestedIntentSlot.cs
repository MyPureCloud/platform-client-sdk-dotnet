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
    /// ConversationResponseSuggestionsTopicSuggestedIntentSlot
    /// </summary>
    [DataContract]
    public partial class ConversationResponseSuggestionsTopicSuggestedIntentSlot :  IEquatable<ConversationResponseSuggestionsTopicSuggestedIntentSlot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResponseSuggestionsTopicSuggestedIntentSlot" /> class.
        /// </summary>
        /// <param name="SlotName">SlotName.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="SlotValue">SlotValue.</param>
        /// <param name="Probability">Probability.</param>
        public ConversationResponseSuggestionsTopicSuggestedIntentSlot(string SlotName = null, string EntityType = null, string SlotValue = null, double? Probability = null)
        {
            this.SlotName = SlotName;
            this.EntityType = EntityType;
            this.SlotValue = SlotValue;
            this.Probability = Probability;
            
        }
        


        /// <summary>
        /// Gets or Sets SlotName
        /// </summary>
        [DataMember(Name="slotName", EmitDefaultValue=false)]
        public string SlotName { get; set; }



        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }



        /// <summary>
        /// Gets or Sets SlotValue
        /// </summary>
        [DataMember(Name="slotValue", EmitDefaultValue=false)]
        public string SlotValue { get; set; }



        /// <summary>
        /// Gets or Sets Probability
        /// </summary>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public double? Probability { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationResponseSuggestionsTopicSuggestedIntentSlot {\n");

            sb.Append("  SlotName: ").Append(SlotName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  SlotValue: ").Append(SlotValue).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
            return this.Equals(obj as ConversationResponseSuggestionsTopicSuggestedIntentSlot);
        }

        /// <summary>
        /// Returns true if ConversationResponseSuggestionsTopicSuggestedIntentSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationResponseSuggestionsTopicSuggestedIntentSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationResponseSuggestionsTopicSuggestedIntentSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SlotName == other.SlotName ||
                    this.SlotName != null &&
                    this.SlotName.Equals(other.SlotName)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.SlotValue == other.SlotValue ||
                    this.SlotValue != null &&
                    this.SlotValue.Equals(other.SlotValue)
                ) &&
                (
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
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
                if (this.SlotName != null)
                    hash = hash * 59 + this.SlotName.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.SlotValue != null)
                    hash = hash * 59 + this.SlotValue.GetHashCode();

                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();

                return hash;
            }
        }
    }

}
