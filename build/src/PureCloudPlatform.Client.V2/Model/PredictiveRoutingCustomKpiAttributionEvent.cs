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
        /// <param name="EventId">A unique UUID v4 used to identify each attribution event uniquely (required).</param>
        /// <param name="EventDateTime">The date and time at which the attributed business result was achieved, in UTC, formatted as an ISO-8601 string. For example, 2023-01-07T08:30:00.123Z. Use the time the business result actually occurred or was confirmed, not a later ingestion, synchronisation, reporting, or batch-processing time. When conversationId is supplied, this timestamp must fall within the conversation attribution window, or the event is rejected. This means eventDateTime must be no earlier than the conversation start time, and no later than the conversation end time plus the grace period for the conversation&#39;s media type (1 hour for voice, message and email). (required).</param>
        /// <param name="ExternalContactId">The id of the External Contact of the customer who was involved in the KPI attribution. If this field is populated, we will retrieve the relevant conversation internally - thus this field is not compatible with conversationId. You must chose to use either externalContactId or conversationId but not both on the same event..</param>
        /// <param name="ConversationId">The id of the conversation. This field must be omitted if externalContactId is already populated on the event..</param>
        /// <param name="AgentId">The id of the agent who achieved the KPI attribution that is getting the attribution..</param>
        /// <param name="KpiId">The id of the relevant revenue KPI within the Genesys Platform - this id can be retrieved from the Revenue KPI Admin UI. (required).</param>
        /// <param name="AssociatedValue">For Sales Conversion, Retention and Churn KPI type, the numeric value expected is \&quot;1\&quot;. For SalesValue KPI type, a numeric value representing the aggregated value of all KPI attributions achieved by an agent during a conversation, we do not allow multiple event uploads for the same conversationId and agentId pair. (required).</param>
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
        /// A unique UUID v4 used to identify each attribution event uniquely
        /// </summary>
        /// <value>A unique UUID v4 used to identify each attribution event uniquely</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }



        /// <summary>
        /// The date and time at which the attributed business result was achieved, in UTC, formatted as an ISO-8601 string. For example, 2023-01-07T08:30:00.123Z. Use the time the business result actually occurred or was confirmed, not a later ingestion, synchronisation, reporting, or batch-processing time. When conversationId is supplied, this timestamp must fall within the conversation attribution window, or the event is rejected. This means eventDateTime must be no earlier than the conversation start time, and no later than the conversation end time plus the grace period for the conversation&#39;s media type (1 hour for voice, message and email).
        /// </summary>
        /// <value>The date and time at which the attributed business result was achieved, in UTC, formatted as an ISO-8601 string. For example, 2023-01-07T08:30:00.123Z. Use the time the business result actually occurred or was confirmed, not a later ingestion, synchronisation, reporting, or batch-processing time. When conversationId is supplied, this timestamp must fall within the conversation attribution window, or the event is rejected. This means eventDateTime must be no earlier than the conversation start time, and no later than the conversation end time plus the grace period for the conversation&#39;s media type (1 hour for voice, message and email).</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public DateTime? EventDateTime { get; set; }



        /// <summary>
        /// The id of the External Contact of the customer who was involved in the KPI attribution. If this field is populated, we will retrieve the relevant conversation internally - thus this field is not compatible with conversationId. You must chose to use either externalContactId or conversationId but not both on the same event.
        /// </summary>
        /// <value>The id of the External Contact of the customer who was involved in the KPI attribution. If this field is populated, we will retrieve the relevant conversation internally - thus this field is not compatible with conversationId. You must chose to use either externalContactId or conversationId but not both on the same event.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// The id of the conversation. This field must be omitted if externalContactId is already populated on the event.
        /// </summary>
        /// <value>The id of the conversation. This field must be omitted if externalContactId is already populated on the event.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The id of the agent who achieved the KPI attribution that is getting the attribution.
        /// </summary>
        /// <value>The id of the agent who achieved the KPI attribution that is getting the attribution.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The id of the relevant revenue KPI within the Genesys Platform - this id can be retrieved from the Revenue KPI Admin UI.
        /// </summary>
        /// <value>The id of the relevant revenue KPI within the Genesys Platform - this id can be retrieved from the Revenue KPI Admin UI.</value>
        [DataMember(Name="kpiId", EmitDefaultValue=false)]
        public string KpiId { get; set; }



        /// <summary>
        /// For Sales Conversion, Retention and Churn KPI type, the numeric value expected is \&quot;1\&quot;. For SalesValue KPI type, a numeric value representing the aggregated value of all KPI attributions achieved by an agent during a conversation, we do not allow multiple event uploads for the same conversationId and agentId pair.
        /// </summary>
        /// <value>For Sales Conversion, Retention and Churn KPI type, the numeric value expected is \&quot;1\&quot;. For SalesValue KPI type, a numeric value representing the aggregated value of all KPI attributions achieved by an agent during a conversation, we do not allow multiple event uploads for the same conversationId and agentId pair.</value>
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
