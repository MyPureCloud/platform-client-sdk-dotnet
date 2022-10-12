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
    /// EndTransferEvent
    /// </summary>
    [DataContract]
    public partial class EndTransferEvent :  IEquatable<EndTransferEvent>
    {
        /// <summary>
        /// Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.
        /// </summary>
        /// <value>Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FinalStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        /// <summary>
        /// Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.
        /// </summary>
        /// <value>Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.</value>
        [DataMember(Name="finalState", EmitDefaultValue=false)]
        public FinalStateEnum? FinalState { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndTransferEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EndTransferEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndTransferEvent" /> class.
        /// </summary>
        /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
        /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
        /// <param name="CommandId">The id (V4 UUID) used to identify the transfer already started by the external platform. (required).</param>
        /// <param name="FinalState">Indicates whether the transfer completed successfully, was cancelled, or failed for some reason. (required).</param>
        /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that was being transferred. (required).</param>
        public EndTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommandId = null, FinalStateEnum? FinalState = null, string ObjectCommunicationId = null)
        {
            this.EventId = EventId;
            this.EventDateTime = EventDateTime;
            this.ConversationId = ConversationId;
            this.CommandId = CommandId;
            this.FinalState = FinalState;
            this.ObjectCommunicationId = ObjectCommunicationId;
            
        }
        


        /// <summary>
        /// A unique (V4 UUID) eventId for this event
        /// </summary>
        /// <value>A unique (V4 UUID) eventId for this event</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }



        /// <summary>
        /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public DateTime? EventDateTime { get; set; }



        /// <summary>
        /// A unique Id (V4 UUID) identifying this conversation
        /// </summary>
        /// <value>A unique Id (V4 UUID) identifying this conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The id (V4 UUID) used to identify the transfer already started by the external platform.
        /// </summary>
        /// <value>The id (V4 UUID) used to identify the transfer already started by the external platform.</value>
        [DataMember(Name="commandId", EmitDefaultValue=false)]
        public string CommandId { get; set; }





        /// <summary>
        /// The id (V4 UUID) of the communication that was being transferred.
        /// </summary>
        /// <value>The id (V4 UUID) of the communication that was being transferred.</value>
        [DataMember(Name="objectCommunicationId", EmitDefaultValue=false)]
        public string ObjectCommunicationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndTransferEvent {\n");

            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommandId: ").Append(CommandId).Append("\n");
            sb.Append("  FinalState: ").Append(FinalState).Append("\n");
            sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
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
            return this.Equals(obj as EndTransferEvent);
        }

        /// <summary>
        /// Returns true if EndTransferEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of EndTransferEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndTransferEvent other)
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
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.CommandId == other.CommandId ||
                    this.CommandId != null &&
                    this.CommandId.Equals(other.CommandId)
                ) &&
                (
                    this.FinalState == other.FinalState ||
                    this.FinalState != null &&
                    this.FinalState.Equals(other.FinalState)
                ) &&
                (
                    this.ObjectCommunicationId == other.ObjectCommunicationId ||
                    this.ObjectCommunicationId != null &&
                    this.ObjectCommunicationId.Equals(other.ObjectCommunicationId)
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

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.CommandId != null)
                    hash = hash * 59 + this.CommandId.GetHashCode();

                if (this.FinalState != null)
                    hash = hash * 59 + this.FinalState.GetHashCode();

                if (this.ObjectCommunicationId != null)
                    hash = hash * 59 + this.ObjectCommunicationId.GetHashCode();

                return hash;
            }
        }
    }

}
