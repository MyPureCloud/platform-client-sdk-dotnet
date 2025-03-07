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
    /// A subset of the Journey System&#39;s tracked customer session data at a point-in-time (for external linkage and internal usage/context)
    /// </summary>
    [DataContract]
    public partial class ConversationChatEventTopicJourneyCustomerSession :  IEquatable<ConversationChatEventTopicJourneyCustomerSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChatEventTopicJourneyCustomerSession" /> class.
        /// </summary>
        /// <param name="Id">An ID of a Customer/User&#39;s session within the Journey System at a point-in-time.</param>
        /// <param name="Type">The type of the Customer/User&#39;s session within the Journey System (e.g. web, app).</param>
        public ConversationChatEventTopicJourneyCustomerSession(string Id = null, string Type = null)
        {
            this.Id = Id;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// An ID of a Customer/User&#39;s session within the Journey System at a point-in-time
        /// </summary>
        /// <value>An ID of a Customer/User&#39;s session within the Journey System at a point-in-time</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)
        /// </summary>
        /// <value>The type of the Customer/User&#39;s session within the Journey System (e.g. web, app)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationChatEventTopicJourneyCustomerSession {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ConversationChatEventTopicJourneyCustomerSession);
        }

        /// <summary>
        /// Returns true if ConversationChatEventTopicJourneyCustomerSession instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationChatEventTopicJourneyCustomerSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationChatEventTopicJourneyCustomerSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
