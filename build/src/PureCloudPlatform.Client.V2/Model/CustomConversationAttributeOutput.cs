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
    /// Conversation Custom Attribute updates applied to a single record during a guide session turn.
    /// </summary>
    [DataContract]
    public partial class CustomConversationAttributeOutput :  IEquatable<CustomConversationAttributeOutput>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConversationAttributeOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomConversationAttributeOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConversationAttributeOutput" /> class.
        /// </summary>
        /// <param name="RecordId">The ID of the record that was updated. (required).</param>
        /// <param name="Updates">The attribute updates made to this record during the turn..</param>
        public CustomConversationAttributeOutput(string RecordId = null, List<CustomConversationAttributeUpdate> Updates = null)
        {
            this.RecordId = RecordId;
            this.Updates = Updates;
            
        }
        


        /// <summary>
        /// The Conversation Custom Attributes schema the updates were applied to.
        /// </summary>
        /// <value>The Conversation Custom Attributes schema the updates were applied to.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public ConversationAttributeSchema Schema { get; private set; }



        /// <summary>
        /// The ID of the record that was updated.
        /// </summary>
        /// <value>The ID of the record that was updated.</value>
        [DataMember(Name="recordId", EmitDefaultValue=false)]
        public string RecordId { get; set; }



        /// <summary>
        /// The attribute updates made to this record during the turn.
        /// </summary>
        /// <value>The attribute updates made to this record during the turn.</value>
        [DataMember(Name="updates", EmitDefaultValue=false)]
        public List<CustomConversationAttributeUpdate> Updates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomConversationAttributeOutput {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  Updates: ").Append(Updates).Append("\n");
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
            return this.Equals(obj as CustomConversationAttributeOutput);
        }

        /// <summary>
        /// Returns true if CustomConversationAttributeOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomConversationAttributeOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomConversationAttributeOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.RecordId == other.RecordId ||
                    this.RecordId != null &&
                    this.RecordId.Equals(other.RecordId)
                ) &&
                (
                    this.Updates == other.Updates ||
                    this.Updates != null &&
                    this.Updates.SequenceEqual(other.Updates)
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
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this.RecordId != null)
                    hash = hash * 59 + this.RecordId.GetHashCode();

                if (this.Updates != null)
                    hash = hash * 59 + this.Updates.GetHashCode();

                return hash;
            }
        }
    }

}
