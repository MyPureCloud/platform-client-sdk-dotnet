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
    /// ConversationChatEventTopicConversationDivisionMembership
    /// </summary>
    [DataContract]
    public partial class ConversationChatEventTopicConversationDivisionMembership :  IEquatable<ConversationChatEventTopicConversationDivisionMembership>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChatEventTopicConversationDivisionMembership" /> class.
        /// </summary>
        /// <param name="Division">Division.</param>
        /// <param name="Entities">Entities.</param>
        public ConversationChatEventTopicConversationDivisionMembership(ConversationChatEventTopicDomainEntityRef Division = null, List<ConversationChatEventTopicDivisionEntityRef> Entities = null)
        {
            this.Division = Division;
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public ConversationChatEventTopicDomainEntityRef Division { get; set; }



        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<ConversationChatEventTopicDivisionEntityRef> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationChatEventTopicConversationDivisionMembership {\n");

            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as ConversationChatEventTopicConversationDivisionMembership);
        }

        /// <summary>
        /// Returns true if ConversationChatEventTopicConversationDivisionMembership instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationChatEventTopicConversationDivisionMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationChatEventTopicConversationDivisionMembership other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
