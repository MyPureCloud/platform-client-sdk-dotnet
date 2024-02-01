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
    /// A maximum of 100 events are allowed per request
    /// </summary>
    [DataContract]
    public partial class BatchConversationEventRequest :  IEquatable<BatchConversationEventRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchConversationEventRequest" /> class.
        /// </summary>
        /// <param name="EndTransferEvents">Voice - EndTransfer events for this batch.</param>
        /// <param name="PhoneTransferEvents">Voice - PhoneTransfer events for this batch.</param>
        /// <param name="ProgressTransferEvents">Voice - ProgressTransfer events for this batch.</param>
        /// <param name="RoutingTransferEvents">Voice - RoutingTransfer events for this batch.</param>
        /// <param name="UserTransferEvents">Voice - UserTransfer events for this batch.</param>
        /// <param name="CommunicationAnsweredEvents">Voice - CommunicationAnswered events for this batch.</param>
        /// <param name="CommunicationDispositionAppliedEvents">Voice - CommunicationDispositionApplied events for this batch.</param>
        /// <param name="HoldUpdatedEvents">Voice - HoldUpdated events for this batch.</param>
        /// <param name="ExternalEstablishedEvents">Voice - ExternalEstablished events for this batch.</param>
        /// <param name="IvrEstablishedEvents">Voice - IvrEstablished events for this batch.</param>
        /// <param name="PhoneEstablishedEvents">Voice - PhoneEstablished events for this batch.</param>
        /// <param name="RoutingEstablishedEvents">Voice - RoutingEstablished events for this batch.</param>
        /// <param name="UserEstablishedEvents">Voice - UserEstablished events for this batch.</param>
        /// <param name="AudioUpdatedEvents">Voice - AudioUpdated events for this batch.</param>
        /// <param name="CommunicationEndedEvents">Voice - CommunicationEnded events for this batch.</param>
        /// <param name="ConsultTransferEvents">Voice - ConsultTransfer events for this batch.</param>
        /// <param name="ProgressConsultTransferEvents">Voice - ProgressConsultTransfer events for this batch.</param>
        /// <param name="EndConsultTransferEvents">Voice - EndConsultTransfer events for this batch.</param>
        public BatchConversationEventRequest(List<EndTransferEvent> EndTransferEvents = null, List<PhoneTransferEvent> PhoneTransferEvents = null, List<ProgressTransferEvent> ProgressTransferEvents = null, List<RoutingTransferEvent> RoutingTransferEvents = null, List<UserTransferEvent> UserTransferEvents = null, List<CommunicationAnsweredEvent> CommunicationAnsweredEvents = null, List<CommunicationDispositionAppliedEvent> CommunicationDispositionAppliedEvents = null, List<HoldUpdatedEvent> HoldUpdatedEvents = null, List<ExternalEstablishedEvent> ExternalEstablishedEvents = null, List<IvrEstablishedEvent> IvrEstablishedEvents = null, List<PhoneEstablishedEvent> PhoneEstablishedEvents = null, List<RoutingEstablishedEvent> RoutingEstablishedEvents = null, List<UserEstablishedEvent> UserEstablishedEvents = null, List<AudioUpdatedEvent> AudioUpdatedEvents = null, List<CommunicationEndedEvent> CommunicationEndedEvents = null, List<ConsultTransferEvent> ConsultTransferEvents = null, List<ProgressConsultTransferEvent> ProgressConsultTransferEvents = null, List<EndConsultTransferEvent> EndConsultTransferEvents = null)
        {
            this.EndTransferEvents = EndTransferEvents;
            this.PhoneTransferEvents = PhoneTransferEvents;
            this.ProgressTransferEvents = ProgressTransferEvents;
            this.RoutingTransferEvents = RoutingTransferEvents;
            this.UserTransferEvents = UserTransferEvents;
            this.CommunicationAnsweredEvents = CommunicationAnsweredEvents;
            this.CommunicationDispositionAppliedEvents = CommunicationDispositionAppliedEvents;
            this.HoldUpdatedEvents = HoldUpdatedEvents;
            this.ExternalEstablishedEvents = ExternalEstablishedEvents;
            this.IvrEstablishedEvents = IvrEstablishedEvents;
            this.PhoneEstablishedEvents = PhoneEstablishedEvents;
            this.RoutingEstablishedEvents = RoutingEstablishedEvents;
            this.UserEstablishedEvents = UserEstablishedEvents;
            this.AudioUpdatedEvents = AudioUpdatedEvents;
            this.CommunicationEndedEvents = CommunicationEndedEvents;
            this.ConsultTransferEvents = ConsultTransferEvents;
            this.ProgressConsultTransferEvents = ProgressConsultTransferEvents;
            this.EndConsultTransferEvents = EndConsultTransferEvents;
            
        }
        


        /// <summary>
        /// Voice - EndTransfer events for this batch
        /// </summary>
        /// <value>Voice - EndTransfer events for this batch</value>
        [DataMember(Name="endTransferEvents", EmitDefaultValue=false)]
        public List<EndTransferEvent> EndTransferEvents { get; set; }



        /// <summary>
        /// Voice - PhoneTransfer events for this batch
        /// </summary>
        /// <value>Voice - PhoneTransfer events for this batch</value>
        [DataMember(Name="phoneTransferEvents", EmitDefaultValue=false)]
        public List<PhoneTransferEvent> PhoneTransferEvents { get; set; }



        /// <summary>
        /// Voice - ProgressTransfer events for this batch
        /// </summary>
        /// <value>Voice - ProgressTransfer events for this batch</value>
        [DataMember(Name="progressTransferEvents", EmitDefaultValue=false)]
        public List<ProgressTransferEvent> ProgressTransferEvents { get; set; }



        /// <summary>
        /// Voice - RoutingTransfer events for this batch
        /// </summary>
        /// <value>Voice - RoutingTransfer events for this batch</value>
        [DataMember(Name="routingTransferEvents", EmitDefaultValue=false)]
        public List<RoutingTransferEvent> RoutingTransferEvents { get; set; }



        /// <summary>
        /// Voice - UserTransfer events for this batch
        /// </summary>
        /// <value>Voice - UserTransfer events for this batch</value>
        [DataMember(Name="userTransferEvents", EmitDefaultValue=false)]
        public List<UserTransferEvent> UserTransferEvents { get; set; }



        /// <summary>
        /// Voice - CommunicationAnswered events for this batch
        /// </summary>
        /// <value>Voice - CommunicationAnswered events for this batch</value>
        [DataMember(Name="communicationAnsweredEvents", EmitDefaultValue=false)]
        public List<CommunicationAnsweredEvent> CommunicationAnsweredEvents { get; set; }



        /// <summary>
        /// Voice - CommunicationDispositionApplied events for this batch
        /// </summary>
        /// <value>Voice - CommunicationDispositionApplied events for this batch</value>
        [DataMember(Name="communicationDispositionAppliedEvents", EmitDefaultValue=false)]
        public List<CommunicationDispositionAppliedEvent> CommunicationDispositionAppliedEvents { get; set; }



        /// <summary>
        /// Voice - HoldUpdated events for this batch
        /// </summary>
        /// <value>Voice - HoldUpdated events for this batch</value>
        [DataMember(Name="holdUpdatedEvents", EmitDefaultValue=false)]
        public List<HoldUpdatedEvent> HoldUpdatedEvents { get; set; }



        /// <summary>
        /// Voice - ExternalEstablished events for this batch
        /// </summary>
        /// <value>Voice - ExternalEstablished events for this batch</value>
        [DataMember(Name="externalEstablishedEvents", EmitDefaultValue=false)]
        public List<ExternalEstablishedEvent> ExternalEstablishedEvents { get; set; }



        /// <summary>
        /// Voice - IvrEstablished events for this batch
        /// </summary>
        /// <value>Voice - IvrEstablished events for this batch</value>
        [DataMember(Name="ivrEstablishedEvents", EmitDefaultValue=false)]
        public List<IvrEstablishedEvent> IvrEstablishedEvents { get; set; }



        /// <summary>
        /// Voice - PhoneEstablished events for this batch
        /// </summary>
        /// <value>Voice - PhoneEstablished events for this batch</value>
        [DataMember(Name="phoneEstablishedEvents", EmitDefaultValue=false)]
        public List<PhoneEstablishedEvent> PhoneEstablishedEvents { get; set; }



        /// <summary>
        /// Voice - RoutingEstablished events for this batch
        /// </summary>
        /// <value>Voice - RoutingEstablished events for this batch</value>
        [DataMember(Name="routingEstablishedEvents", EmitDefaultValue=false)]
        public List<RoutingEstablishedEvent> RoutingEstablishedEvents { get; set; }



        /// <summary>
        /// Voice - UserEstablished events for this batch
        /// </summary>
        /// <value>Voice - UserEstablished events for this batch</value>
        [DataMember(Name="userEstablishedEvents", EmitDefaultValue=false)]
        public List<UserEstablishedEvent> UserEstablishedEvents { get; set; }



        /// <summary>
        /// Voice - AudioUpdated events for this batch
        /// </summary>
        /// <value>Voice - AudioUpdated events for this batch</value>
        [DataMember(Name="audioUpdatedEvents", EmitDefaultValue=false)]
        public List<AudioUpdatedEvent> AudioUpdatedEvents { get; set; }



        /// <summary>
        /// Voice - CommunicationEnded events for this batch
        /// </summary>
        /// <value>Voice - CommunicationEnded events for this batch</value>
        [DataMember(Name="communicationEndedEvents", EmitDefaultValue=false)]
        public List<CommunicationEndedEvent> CommunicationEndedEvents { get; set; }



        /// <summary>
        /// Voice - ConsultTransfer events for this batch
        /// </summary>
        /// <value>Voice - ConsultTransfer events for this batch</value>
        [DataMember(Name="consultTransferEvents", EmitDefaultValue=false)]
        public List<ConsultTransferEvent> ConsultTransferEvents { get; set; }



        /// <summary>
        /// Voice - ProgressConsultTransfer events for this batch
        /// </summary>
        /// <value>Voice - ProgressConsultTransfer events for this batch</value>
        [DataMember(Name="progressConsultTransferEvents", EmitDefaultValue=false)]
        public List<ProgressConsultTransferEvent> ProgressConsultTransferEvents { get; set; }



        /// <summary>
        /// Voice - EndConsultTransfer events for this batch
        /// </summary>
        /// <value>Voice - EndConsultTransfer events for this batch</value>
        [DataMember(Name="endConsultTransferEvents", EmitDefaultValue=false)]
        public List<EndConsultTransferEvent> EndConsultTransferEvents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchConversationEventRequest {\n");

            sb.Append("  EndTransferEvents: ").Append(EndTransferEvents).Append("\n");
            sb.Append("  PhoneTransferEvents: ").Append(PhoneTransferEvents).Append("\n");
            sb.Append("  ProgressTransferEvents: ").Append(ProgressTransferEvents).Append("\n");
            sb.Append("  RoutingTransferEvents: ").Append(RoutingTransferEvents).Append("\n");
            sb.Append("  UserTransferEvents: ").Append(UserTransferEvents).Append("\n");
            sb.Append("  CommunicationAnsweredEvents: ").Append(CommunicationAnsweredEvents).Append("\n");
            sb.Append("  CommunicationDispositionAppliedEvents: ").Append(CommunicationDispositionAppliedEvents).Append("\n");
            sb.Append("  HoldUpdatedEvents: ").Append(HoldUpdatedEvents).Append("\n");
            sb.Append("  ExternalEstablishedEvents: ").Append(ExternalEstablishedEvents).Append("\n");
            sb.Append("  IvrEstablishedEvents: ").Append(IvrEstablishedEvents).Append("\n");
            sb.Append("  PhoneEstablishedEvents: ").Append(PhoneEstablishedEvents).Append("\n");
            sb.Append("  RoutingEstablishedEvents: ").Append(RoutingEstablishedEvents).Append("\n");
            sb.Append("  UserEstablishedEvents: ").Append(UserEstablishedEvents).Append("\n");
            sb.Append("  AudioUpdatedEvents: ").Append(AudioUpdatedEvents).Append("\n");
            sb.Append("  CommunicationEndedEvents: ").Append(CommunicationEndedEvents).Append("\n");
            sb.Append("  ConsultTransferEvents: ").Append(ConsultTransferEvents).Append("\n");
            sb.Append("  ProgressConsultTransferEvents: ").Append(ProgressConsultTransferEvents).Append("\n");
            sb.Append("  EndConsultTransferEvents: ").Append(EndConsultTransferEvents).Append("\n");
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
            return this.Equals(obj as BatchConversationEventRequest);
        }

        /// <summary>
        /// Returns true if BatchConversationEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchConversationEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchConversationEventRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndTransferEvents == other.EndTransferEvents ||
                    this.EndTransferEvents != null &&
                    this.EndTransferEvents.SequenceEqual(other.EndTransferEvents)
                ) &&
                (
                    this.PhoneTransferEvents == other.PhoneTransferEvents ||
                    this.PhoneTransferEvents != null &&
                    this.PhoneTransferEvents.SequenceEqual(other.PhoneTransferEvents)
                ) &&
                (
                    this.ProgressTransferEvents == other.ProgressTransferEvents ||
                    this.ProgressTransferEvents != null &&
                    this.ProgressTransferEvents.SequenceEqual(other.ProgressTransferEvents)
                ) &&
                (
                    this.RoutingTransferEvents == other.RoutingTransferEvents ||
                    this.RoutingTransferEvents != null &&
                    this.RoutingTransferEvents.SequenceEqual(other.RoutingTransferEvents)
                ) &&
                (
                    this.UserTransferEvents == other.UserTransferEvents ||
                    this.UserTransferEvents != null &&
                    this.UserTransferEvents.SequenceEqual(other.UserTransferEvents)
                ) &&
                (
                    this.CommunicationAnsweredEvents == other.CommunicationAnsweredEvents ||
                    this.CommunicationAnsweredEvents != null &&
                    this.CommunicationAnsweredEvents.SequenceEqual(other.CommunicationAnsweredEvents)
                ) &&
                (
                    this.CommunicationDispositionAppliedEvents == other.CommunicationDispositionAppliedEvents ||
                    this.CommunicationDispositionAppliedEvents != null &&
                    this.CommunicationDispositionAppliedEvents.SequenceEqual(other.CommunicationDispositionAppliedEvents)
                ) &&
                (
                    this.HoldUpdatedEvents == other.HoldUpdatedEvents ||
                    this.HoldUpdatedEvents != null &&
                    this.HoldUpdatedEvents.SequenceEqual(other.HoldUpdatedEvents)
                ) &&
                (
                    this.ExternalEstablishedEvents == other.ExternalEstablishedEvents ||
                    this.ExternalEstablishedEvents != null &&
                    this.ExternalEstablishedEvents.SequenceEqual(other.ExternalEstablishedEvents)
                ) &&
                (
                    this.IvrEstablishedEvents == other.IvrEstablishedEvents ||
                    this.IvrEstablishedEvents != null &&
                    this.IvrEstablishedEvents.SequenceEqual(other.IvrEstablishedEvents)
                ) &&
                (
                    this.PhoneEstablishedEvents == other.PhoneEstablishedEvents ||
                    this.PhoneEstablishedEvents != null &&
                    this.PhoneEstablishedEvents.SequenceEqual(other.PhoneEstablishedEvents)
                ) &&
                (
                    this.RoutingEstablishedEvents == other.RoutingEstablishedEvents ||
                    this.RoutingEstablishedEvents != null &&
                    this.RoutingEstablishedEvents.SequenceEqual(other.RoutingEstablishedEvents)
                ) &&
                (
                    this.UserEstablishedEvents == other.UserEstablishedEvents ||
                    this.UserEstablishedEvents != null &&
                    this.UserEstablishedEvents.SequenceEqual(other.UserEstablishedEvents)
                ) &&
                (
                    this.AudioUpdatedEvents == other.AudioUpdatedEvents ||
                    this.AudioUpdatedEvents != null &&
                    this.AudioUpdatedEvents.SequenceEqual(other.AudioUpdatedEvents)
                ) &&
                (
                    this.CommunicationEndedEvents == other.CommunicationEndedEvents ||
                    this.CommunicationEndedEvents != null &&
                    this.CommunicationEndedEvents.SequenceEqual(other.CommunicationEndedEvents)
                ) &&
                (
                    this.ConsultTransferEvents == other.ConsultTransferEvents ||
                    this.ConsultTransferEvents != null &&
                    this.ConsultTransferEvents.SequenceEqual(other.ConsultTransferEvents)
                ) &&
                (
                    this.ProgressConsultTransferEvents == other.ProgressConsultTransferEvents ||
                    this.ProgressConsultTransferEvents != null &&
                    this.ProgressConsultTransferEvents.SequenceEqual(other.ProgressConsultTransferEvents)
                ) &&
                (
                    this.EndConsultTransferEvents == other.EndConsultTransferEvents ||
                    this.EndConsultTransferEvents != null &&
                    this.EndConsultTransferEvents.SequenceEqual(other.EndConsultTransferEvents)
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
                if (this.EndTransferEvents != null)
                    hash = hash * 59 + this.EndTransferEvents.GetHashCode();

                if (this.PhoneTransferEvents != null)
                    hash = hash * 59 + this.PhoneTransferEvents.GetHashCode();

                if (this.ProgressTransferEvents != null)
                    hash = hash * 59 + this.ProgressTransferEvents.GetHashCode();

                if (this.RoutingTransferEvents != null)
                    hash = hash * 59 + this.RoutingTransferEvents.GetHashCode();

                if (this.UserTransferEvents != null)
                    hash = hash * 59 + this.UserTransferEvents.GetHashCode();

                if (this.CommunicationAnsweredEvents != null)
                    hash = hash * 59 + this.CommunicationAnsweredEvents.GetHashCode();

                if (this.CommunicationDispositionAppliedEvents != null)
                    hash = hash * 59 + this.CommunicationDispositionAppliedEvents.GetHashCode();

                if (this.HoldUpdatedEvents != null)
                    hash = hash * 59 + this.HoldUpdatedEvents.GetHashCode();

                if (this.ExternalEstablishedEvents != null)
                    hash = hash * 59 + this.ExternalEstablishedEvents.GetHashCode();

                if (this.IvrEstablishedEvents != null)
                    hash = hash * 59 + this.IvrEstablishedEvents.GetHashCode();

                if (this.PhoneEstablishedEvents != null)
                    hash = hash * 59 + this.PhoneEstablishedEvents.GetHashCode();

                if (this.RoutingEstablishedEvents != null)
                    hash = hash * 59 + this.RoutingEstablishedEvents.GetHashCode();

                if (this.UserEstablishedEvents != null)
                    hash = hash * 59 + this.UserEstablishedEvents.GetHashCode();

                if (this.AudioUpdatedEvents != null)
                    hash = hash * 59 + this.AudioUpdatedEvents.GetHashCode();

                if (this.CommunicationEndedEvents != null)
                    hash = hash * 59 + this.CommunicationEndedEvents.GetHashCode();

                if (this.ConsultTransferEvents != null)
                    hash = hash * 59 + this.ConsultTransferEvents.GetHashCode();

                if (this.ProgressConsultTransferEvents != null)
                    hash = hash * 59 + this.ProgressConsultTransferEvents.GetHashCode();

                if (this.EndConsultTransferEvents != null)
                    hash = hash * 59 + this.EndConsultTransferEvents.GetHashCode();

                return hash;
            }
        }
    }

}
