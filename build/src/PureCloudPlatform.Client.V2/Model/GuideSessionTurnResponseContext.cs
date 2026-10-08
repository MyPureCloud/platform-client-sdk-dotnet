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
    /// Context returned from a guide session turn, including conversation custom attribute updates.
    /// </summary>
    [DataContract]
    public partial class GuideSessionTurnResponseContext :  IEquatable<GuideSessionTurnResponseContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionTurnResponseContext" /> class.
        /// </summary>
        /// <param name="CustomConversationAttributes">The Conversation Custom Attributes updates made during this turn..</param>
        public GuideSessionTurnResponseContext(List<CustomConversationAttributeOutput> CustomConversationAttributes = null)
        {
            this.CustomConversationAttributes = CustomConversationAttributes;
            
        }
        


        /// <summary>
        /// The Conversation Custom Attributes updates made during this turn.
        /// </summary>
        /// <value>The Conversation Custom Attributes updates made during this turn.</value>
        [DataMember(Name="customConversationAttributes", EmitDefaultValue=false)]
        public List<CustomConversationAttributeOutput> CustomConversationAttributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionTurnResponseContext {\n");

            sb.Append("  CustomConversationAttributes: ").Append(CustomConversationAttributes).Append("\n");
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
            return this.Equals(obj as GuideSessionTurnResponseContext);
        }

        /// <summary>
        /// Returns true if GuideSessionTurnResponseContext instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionTurnResponseContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionTurnResponseContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CustomConversationAttributes == other.CustomConversationAttributes ||
                    this.CustomConversationAttributes != null &&
                    this.CustomConversationAttributes.SequenceEqual(other.CustomConversationAttributes)
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
                if (this.CustomConversationAttributes != null)
                    hash = hash * 59 + this.CustomConversationAttributes.GetHashCode();

                return hash;
            }
        }
    }

}
