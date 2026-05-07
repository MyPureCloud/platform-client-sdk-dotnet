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
    /// PredictiveRoutingCustomKpiAttributionEvent
    /// </summary>
    [DataContract]
    public partial class PredictiveRoutingCustomKpiAttributionEvent :  IEquatable<PredictiveRoutingCustomKpiAttributionEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictiveRoutingCustomKpiAttributionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PredictiveRoutingCustomKpiAttributionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictiveRoutingCustomKpiAttributionEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ExternalContactId">The UUID of the external contact associated with this event.</param>
        /// <param name="ConversationId">The UUID of the conversation associated with this event.</param>
        /// <param name="AgentId">The UUID of the agent associated with this event.</param>
        /// <param name="KpiId">The UUID of the KPI associated with this event (required).</param>
        /// <param name="AssociatedValue">The value associated with this outcome attribution (required).</param>
        public PredictiveRoutingCustomKpiAttributionEvent(string EventId = null, DateTime? EventDateTime = null, string ExternalContactId = null, string ConversationId = null, string AgentId = null, string KpiId = null, double? AssociatedValue = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ExternalContactId = ExternalContactId;
            this.ConversationId = ConversationId;
            this.AgentId = AgentId;
            this.KpiId = KpiId;
            this.AssociatedValue = AssociatedValue;
            
        }
        


        /// <summary>
        /// A unique (UUID) eventId for this event
        /// </summary>
        /// <value>A unique (UUID) eventId for this event</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }



        /// <summary>
        /// A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public DateTime? EventDateTime { get; set; }



        /// <summary>
        /// The UUID of the external contact associated with this event
        /// </summary>
        /// <value>The UUID of the external contact associated with this event</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// The UUID of the conversation associated with this event
        /// </summary>
        /// <value>The UUID of the conversation associated with this event</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The UUID of the agent associated with this event
        /// </summary>
        /// <value>The UUID of the agent associated with this event</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The UUID of the KPI associated with this event
        /// </summary>
        /// <value>The UUID of the KPI associated with this event</value>
        [DataMember(Name="kpiId", EmitDefaultValue=false)]
        public string KpiId { get; set; }



        /// <summary>
        /// The value associated with this outcome attribution
        /// </summary>
        /// <value>The value associated with this outcome attribution</value>
        [DataMember(Name="associatedValue", EmitDefaultValue=false)]
        public double? AssociatedValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictiveRoutingCustomKpiAttributionEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  KpiId: ").Append(KpiId).Append("\n");
            sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
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
            return this.Equals(obj as PredictiveRoutingCustomKpiAttributionEvent);
        }

        /// <summary>
        /// Returns true if PredictiveRoutingCustomKpiAttributionEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of PredictiveRoutingCustomKpiAttributionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictiveRoutingCustomKpiAttributionEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) &&
                (
                    this.EventDateTime == other.EventDateTime ||
                    this.EventDateTime != null &&
                    this.EventDateTime.Equals(other.EventDateTime)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.KpiId == other.KpiId ||
                    this.KpiId != null &&
                    this.KpiId.Equals(other.KpiId)
                ) &&
                (
                    this.AssociatedValue == other.AssociatedValue ||
                    this.AssociatedValue != null &&
                    this.AssociatedValue.Equals(other.AssociatedValue)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();

                if (this.EventDateTime != null)
                    hash = hash * 59 + this.EventDateTime.GetHashCode();

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.KpiId != null)
                    hash = hash * 59 + this.KpiId.GetHashCode();

                if (this.AssociatedValue != null)
                    hash = hash * 59 + this.AssociatedValue.GetHashCode();

                return hash;
            }
        }
    }

}
