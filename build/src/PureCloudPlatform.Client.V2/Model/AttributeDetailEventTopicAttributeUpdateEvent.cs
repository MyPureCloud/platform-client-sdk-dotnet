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
    /// AttributeDetailEventTopicAttributeUpdateEvent
    /// </summary>
    [DataContract]
    public partial class AttributeDetailEventTopicAttributeUpdateEvent :  IEquatable<AttributeDetailEventTopicAttributeUpdateEvent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeDetailEventTopicAttributeUpdateEvent" /> class.
        /// </summary>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="ParticipantId">ParticipantId.</param>
        /// <param name="Attributes">Attributes.</param>
        public AttributeDetailEventTopicAttributeUpdateEvent(int? EventTime = null, string ConversationId = null, string ParticipantId = null, Dictionary<string, string> Attributes = null)
        {
            this.EventTime = EventTime;
            this.ConversationId = ConversationId;
            this.ParticipantId = ParticipantId;
            this.Attributes = Attributes;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public int? EventTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ParticipantId
        /// </summary>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeDetailEventTopicAttributeUpdateEvent {\n");
            
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as AttributeDetailEventTopicAttributeUpdateEvent);
        }

        /// <summary>
        /// Returns true if AttributeDetailEventTopicAttributeUpdateEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of AttributeDetailEventTopicAttributeUpdateEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeDetailEventTopicAttributeUpdateEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                return hash;
            }
        }
    }

}
