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
    /// A Conversation Custom Attributes schema and its associated records made available to a guide session turn.
    /// </summary>
    [DataContract]
    public partial class CustomConversationAttributeInput :  IEquatable<CustomConversationAttributeInput>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConversationAttributeInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomConversationAttributeInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConversationAttributeInput" /> class.
        /// </summary>
        /// <param name="SchemaId">The ID of the Conversation Custom Attributes schema. (required).</param>
        /// <param name="DivisionIds">The division IDs associated with this schema..</param>
        /// <param name="RecordIds">The record IDs associated with this schema..</param>
        public CustomConversationAttributeInput(string SchemaId = null, List<string> DivisionIds = null, List<string> RecordIds = null)
        {
            this.SchemaId = SchemaId;
            this.DivisionIds = DivisionIds;
            this.RecordIds = RecordIds;
            
        }
        


        /// <summary>
        /// The ID of the Conversation Custom Attributes schema.
        /// </summary>
        /// <value>The ID of the Conversation Custom Attributes schema.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; set; }



        /// <summary>
        /// The division IDs associated with this schema.
        /// </summary>
        /// <value>The division IDs associated with this schema.</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }



        /// <summary>
        /// The record IDs associated with this schema.
        /// </summary>
        /// <value>The record IDs associated with this schema.</value>
        [DataMember(Name="recordIds", EmitDefaultValue=false)]
        public List<string> RecordIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomConversationAttributeInput {\n");

            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  RecordIds: ").Append(RecordIds).Append("\n");
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
            return this.Equals(obj as CustomConversationAttributeInput);
        }

        /// <summary>
        /// Returns true if CustomConversationAttributeInput instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomConversationAttributeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomConversationAttributeInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.RecordIds == other.RecordIds ||
                    this.RecordIds != null &&
                    this.RecordIds.SequenceEqual(other.RecordIds)
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
                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();

                if (this.RecordIds != null)
                    hash = hash * 59 + this.RecordIds.GetHashCode();

                return hash;
            }
        }
    }

}
