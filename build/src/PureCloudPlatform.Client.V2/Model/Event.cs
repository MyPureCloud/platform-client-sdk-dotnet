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
    /// Event
    /// </summary>
    [DataContract]
    public partial class Event :  IEquatable<Event>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="Id">System-generated UUID for the event..</param>
        /// <param name="CustomerId">Primary identifier of the customer in the source of the events..</param>
        /// <param name="CustomerIdType">Type of primary identifier (e.g. cookie, email, phone)..</param>
        /// <param name="Session">The session that the event belongs to..</param>
        /// <param name="EventType">The name representing the type of event. (required).</param>
        /// <param name="GenericActionEvent">Event triggered by generic actions..</param>
        /// <param name="OutcomeAchievedEvent">Event where a customer has achieved a specific outcome or goal..</param>
        /// <param name="SegmentAssignedEvent">Event that represents a segment being assigned (deprecated)..</param>
        /// <param name="SegmentAssignmentEvent">Event that represents a segment being assigned..</param>
        /// <param name="WebActionEvent">Event triggered by web actions..</param>
        /// <param name="WebEvent">Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc..</param>
        /// <param name="CreatedDate">Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public Event(string Id = null, string CustomerId = null, string CustomerIdType = null, EventSession Session = null, string EventType = null, GenericActionEvent GenericActionEvent = null, OutcomeAchievedEvent OutcomeAchievedEvent = null, SegmentAssignedEvent SegmentAssignedEvent = null, SegmentAssignmentEvent SegmentAssignmentEvent = null, WebActionEvent WebActionEvent = null, WebEvent WebEvent = null, DateTime? CreatedDate = null)
        {
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.CustomerIdType = CustomerIdType;
            this.Session = Session;
            this.EventType = EventType;
            this.GenericActionEvent = GenericActionEvent;
            this.OutcomeAchievedEvent = OutcomeAchievedEvent;
            this.SegmentAssignedEvent = SegmentAssignedEvent;
            this.SegmentAssignmentEvent = SegmentAssignmentEvent;
            this.WebActionEvent = WebActionEvent;
            this.WebEvent = WebEvent;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// System-generated UUID for the event.
        /// </summary>
        /// <value>System-generated UUID for the event.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event).
        /// </summary>
        /// <value>UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event).</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; private set; }



        /// <summary>
        /// Primary identifier of the customer in the source of the events.
        /// </summary>
        /// <value>Primary identifier of the customer in the source of the events.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Type of primary identifier (e.g. cookie, email, phone).
        /// </summary>
        /// <value>Type of primary identifier (e.g. cookie, email, phone).</value>
        [DataMember(Name="customerIdType", EmitDefaultValue=false)]
        public string CustomerIdType { get; set; }



        /// <summary>
        /// The session that the event belongs to.
        /// </summary>
        /// <value>The session that the event belongs to.</value>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public EventSession Session { get; set; }



        /// <summary>
        /// The name representing the type of event.
        /// </summary>
        /// <value>The name representing the type of event.</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }



        /// <summary>
        /// Event triggered by generic actions.
        /// </summary>
        /// <value>Event triggered by generic actions.</value>
        [DataMember(Name="genericActionEvent", EmitDefaultValue=false)]
        public GenericActionEvent GenericActionEvent { get; set; }



        /// <summary>
        /// Event where a customer has achieved a specific outcome or goal.
        /// </summary>
        /// <value>Event where a customer has achieved a specific outcome or goal.</value>
        [DataMember(Name="outcomeAchievedEvent", EmitDefaultValue=false)]
        public OutcomeAchievedEvent OutcomeAchievedEvent { get; set; }



        /// <summary>
        /// Event that represents a segment being assigned (deprecated).
        /// </summary>
        /// <value>Event that represents a segment being assigned (deprecated).</value>
        [DataMember(Name="segmentAssignedEvent", EmitDefaultValue=false)]
        public SegmentAssignedEvent SegmentAssignedEvent { get; set; }



        /// <summary>
        /// Event that represents a segment being assigned.
        /// </summary>
        /// <value>Event that represents a segment being assigned.</value>
        [DataMember(Name="segmentAssignmentEvent", EmitDefaultValue=false)]
        public SegmentAssignmentEvent SegmentAssignmentEvent { get; set; }



        /// <summary>
        /// Event triggered by web actions.
        /// </summary>
        /// <value>Event triggered by web actions.</value>
        [DataMember(Name="webActionEvent", EmitDefaultValue=false)]
        public WebActionEvent WebActionEvent { get; set; }



        /// <summary>
        /// Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc.
        /// </summary>
        /// <value>Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc.</value>
        [DataMember(Name="webEvent", EmitDefaultValue=false)]
        public WebEvent WebEvent { get; set; }



        /// <summary>
        /// Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  GenericActionEvent: ").Append(GenericActionEvent).Append("\n");
            sb.Append("  OutcomeAchievedEvent: ").Append(OutcomeAchievedEvent).Append("\n");
            sb.Append("  SegmentAssignedEvent: ").Append(SegmentAssignedEvent).Append("\n");
            sb.Append("  SegmentAssignmentEvent: ").Append(SegmentAssignmentEvent).Append("\n");
            sb.Append("  WebActionEvent: ").Append(WebActionEvent).Append("\n");
            sb.Append("  WebEvent: ").Append(WebEvent).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(obj as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="other">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event other)
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
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.CustomerIdType == other.CustomerIdType ||
                    this.CustomerIdType != null &&
                    this.CustomerIdType.Equals(other.CustomerIdType)
                ) &&
                (
                    this.Session == other.Session ||
                    this.Session != null &&
                    this.Session.Equals(other.Session)
                ) &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.GenericActionEvent == other.GenericActionEvent ||
                    this.GenericActionEvent != null &&
                    this.GenericActionEvent.Equals(other.GenericActionEvent)
                ) &&
                (
                    this.OutcomeAchievedEvent == other.OutcomeAchievedEvent ||
                    this.OutcomeAchievedEvent != null &&
                    this.OutcomeAchievedEvent.Equals(other.OutcomeAchievedEvent)
                ) &&
                (
                    this.SegmentAssignedEvent == other.SegmentAssignedEvent ||
                    this.SegmentAssignedEvent != null &&
                    this.SegmentAssignedEvent.Equals(other.SegmentAssignedEvent)
                ) &&
                (
                    this.SegmentAssignmentEvent == other.SegmentAssignmentEvent ||
                    this.SegmentAssignmentEvent != null &&
                    this.SegmentAssignmentEvent.Equals(other.SegmentAssignmentEvent)
                ) &&
                (
                    this.WebActionEvent == other.WebActionEvent ||
                    this.WebActionEvent != null &&
                    this.WebActionEvent.Equals(other.WebActionEvent)
                ) &&
                (
                    this.WebEvent == other.WebEvent ||
                    this.WebEvent != null &&
                    this.WebEvent.Equals(other.WebEvent)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.CustomerIdType != null)
                    hash = hash * 59 + this.CustomerIdType.GetHashCode();

                if (this.Session != null)
                    hash = hash * 59 + this.Session.GetHashCode();

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.GenericActionEvent != null)
                    hash = hash * 59 + this.GenericActionEvent.GetHashCode();

                if (this.OutcomeAchievedEvent != null)
                    hash = hash * 59 + this.OutcomeAchievedEvent.GetHashCode();

                if (this.SegmentAssignedEvent != null)
                    hash = hash * 59 + this.SegmentAssignedEvent.GetHashCode();

                if (this.SegmentAssignmentEvent != null)
                    hash = hash * 59 + this.SegmentAssignmentEvent.GetHashCode();

                if (this.WebActionEvent != null)
                    hash = hash * 59 + this.WebActionEvent.GetHashCode();

                if (this.WebEvent != null)
                    hash = hash * 59 + this.WebEvent.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
