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
    /// A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)
    /// </summary>
    [DataContract]
    public partial class QueueConversationEmailEventTopicJourneyAction :  IEquatable<QueueConversationEmailEventTopicJourneyAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEmailEventTopicJourneyAction" /> class.
        /// </summary>
        /// <param name="Id">The ID of an action from the Journey System (an action is spawned from an actionMap).</param>
        /// <param name="ActionMap">ActionMap.</param>
        public QueueConversationEmailEventTopicJourneyAction(string Id = null, QueueConversationEmailEventTopicJourneyActionMap ActionMap = null)
        {
            this.Id = Id;
            this.ActionMap = ActionMap;
            
        }
        


        /// <summary>
        /// The ID of an action from the Journey System (an action is spawned from an actionMap)
        /// </summary>
        /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets ActionMap
        /// </summary>
        [DataMember(Name="actionMap", EmitDefaultValue=false)]
        public QueueConversationEmailEventTopicJourneyActionMap ActionMap { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEmailEventTopicJourneyAction {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
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
            return this.Equals(obj as QueueConversationEmailEventTopicJourneyAction);
        }

        /// <summary>
        /// Returns true if QueueConversationEmailEventTopicJourneyAction instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEmailEventTopicJourneyAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEmailEventTopicJourneyAction other)
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
                    this.ActionMap == other.ActionMap ||
                    this.ActionMap != null &&
                    this.ActionMap.Equals(other.ActionMap)
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

                if (this.ActionMap != null)
                    hash = hash * 59 + this.ActionMap.GetHashCode();

                return hash;
            }
        }
    }

}
