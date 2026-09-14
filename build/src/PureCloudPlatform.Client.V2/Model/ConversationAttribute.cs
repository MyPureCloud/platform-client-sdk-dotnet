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
    /// ConversationAttribute
    /// </summary>
    [DataContract]
    public partial class ConversationAttribute :  IEquatable<ConversationAttribute>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAttribute" /> class.
        /// </summary>
        /// <param name="Schema">The Conversation Custom Attributes schema that the variable is bound to. (required).</param>
        /// <param name="AttributeName">The name of the attribute within the schema that the variable value is bound to. (required).</param>
        public ConversationAttribute(ConversationAttributeSchema Schema = null, string AttributeName = null)
        {
            this.Schema = Schema;
            this.AttributeName = AttributeName;
            
        }
        


        /// <summary>
        /// The Conversation Custom Attributes schema that the variable is bound to.
        /// </summary>
        /// <value>The Conversation Custom Attributes schema that the variable is bound to.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public ConversationAttributeSchema Schema { get; set; }



        /// <summary>
        /// The name of the attribute within the schema that the variable value is bound to.
        /// </summary>
        /// <value>The name of the attribute within the schema that the variable value is bound to.</value>
        [DataMember(Name="attributeName", EmitDefaultValue=false)]
        public string AttributeName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAttribute {\n");

            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
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
            return this.Equals(obj as ConversationAttribute);
        }

        /// <summary>
        /// Returns true if ConversationAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAttribute other)
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
                    this.AttributeName == other.AttributeName ||
                    this.AttributeName != null &&
                    this.AttributeName.Equals(other.AttributeName)
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

                if (this.AttributeName != null)
                    hash = hash * 59 + this.AttributeName.GetHashCode();

                return hash;
            }
        }
    }

}
