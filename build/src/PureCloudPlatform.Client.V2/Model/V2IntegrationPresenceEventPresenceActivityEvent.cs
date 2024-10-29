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
    /// V2IntegrationPresenceEventPresenceActivityEvent
    /// </summary>
    [DataContract]
    public partial class V2IntegrationPresenceEventPresenceActivityEvent :  IEquatable<V2IntegrationPresenceEventPresenceActivityEvent>
    {
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Userpresencestatuschanged for "UserPresenceStatusChanged"
            /// </summary>
            [EnumMember(Value = "UserPresenceStatusChanged")]
            Userpresencestatuschanged,
            
            /// <summary>
            /// Enum Userprimarypresencesourcechanged for "UserPrimaryPresenceSourceChanged"
            /// </summary>
            [EnumMember(Value = "UserPrimaryPresenceSourceChanged")]
            Userprimarypresencesourcechanged
        }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2IntegrationPresenceEventPresenceActivityEvent" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="EventType">EventType.</param>
        /// <param name="Source">Source.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="Message">Message.</param>
        /// <param name="CurrentDisplaySourceId">CurrentDisplaySourceId.</param>
        /// <param name="PreviousDisplaySourceId">PreviousDisplaySourceId.</param>
        public V2IntegrationPresenceEventPresenceActivityEvent(Guid? UserId = null, EventTypeEnum? EventType = null, string Source = null, DateTime? ModifiedDate = null, V2IntegrationPresenceEventOrganizationPresence PresenceDefinition = null, string Message = null, Guid? CurrentDisplaySourceId = null, Guid? PreviousDisplaySourceId = null)
        {
            this.UserId = UserId;
            this.EventType = EventType;
            this.Source = Source;
            this.ModifiedDate = ModifiedDate;
            this.PresenceDefinition = PresenceDefinition;
            this.Message = Message;
            this.CurrentDisplaySourceId = CurrentDisplaySourceId;
            this.PreviousDisplaySourceId = PreviousDisplaySourceId;
            
        }
        


        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }





        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// Gets or Sets PresenceDefinition
        /// </summary>
        [DataMember(Name="presenceDefinition", EmitDefaultValue=false)]
        public V2IntegrationPresenceEventOrganizationPresence PresenceDefinition { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets CurrentDisplaySourceId
        /// </summary>
        [DataMember(Name="currentDisplaySourceId", EmitDefaultValue=false)]
        public Guid? CurrentDisplaySourceId { get; set; }



        /// <summary>
        /// Gets or Sets PreviousDisplaySourceId
        /// </summary>
        [DataMember(Name="previousDisplaySourceId", EmitDefaultValue=false)]
        public Guid? PreviousDisplaySourceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2IntegrationPresenceEventPresenceActivityEvent {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CurrentDisplaySourceId: ").Append(CurrentDisplaySourceId).Append("\n");
            sb.Append("  PreviousDisplaySourceId: ").Append(PreviousDisplaySourceId).Append("\n");
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
            return this.Equals(obj as V2IntegrationPresenceEventPresenceActivityEvent);
        }

        /// <summary>
        /// Returns true if V2IntegrationPresenceEventPresenceActivityEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of V2IntegrationPresenceEventPresenceActivityEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2IntegrationPresenceEventPresenceActivityEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.PresenceDefinition == other.PresenceDefinition ||
                    this.PresenceDefinition != null &&
                    this.PresenceDefinition.Equals(other.PresenceDefinition)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.CurrentDisplaySourceId == other.CurrentDisplaySourceId ||
                    this.CurrentDisplaySourceId != null &&
                    this.CurrentDisplaySourceId.Equals(other.CurrentDisplaySourceId)
                ) &&
                (
                    this.PreviousDisplaySourceId == other.PreviousDisplaySourceId ||
                    this.PreviousDisplaySourceId != null &&
                    this.PreviousDisplaySourceId.Equals(other.PreviousDisplaySourceId)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                if (this.PresenceDefinition != null)
                    hash = hash * 59 + this.PresenceDefinition.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.CurrentDisplaySourceId != null)
                    hash = hash * 59 + this.CurrentDisplaySourceId.GetHashCode();

                if (this.PreviousDisplaySourceId != null)
                    hash = hash * 59 + this.PreviousDisplaySourceId.GetHashCode();

                return hash;
            }
        }
    }

}
