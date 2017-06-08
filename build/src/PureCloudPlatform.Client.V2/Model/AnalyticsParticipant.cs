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
    /// AnalyticsParticipant
    /// </summary>
    [DataContract]
    public partial class AnalyticsParticipant :  IEquatable<AnalyticsParticipant>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PurposeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Manual for "manual"
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual,
            
            /// <summary>
            /// Enum Dialer for "dialer"
            /// </summary>
            [EnumMember(Value = "dialer")]
            Dialer,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Acd for "acd"
            /// </summary>
            [EnumMember(Value = "acd")]
            Acd,
            
            /// <summary>
            /// Enum Ivr for "ivr"
            /// </summary>
            [EnumMember(Value = "ivr")]
            Ivr,
            
            /// <summary>
            /// Enum Voicemail for "voicemail"
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Station for "station"
            /// </summary>
            [EnumMember(Value = "station")]
            Station,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Customer for "customer"
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsParticipant" /> class.
        /// </summary>
        
        
        /// <param name="ParticipantId">ParticipantId.</param>
        
        
        
        /// <param name="ParticipantName">ParticipantName.</param>
        
        
        
        /// <param name="UserId">UserId.</param>
        
        
        
        /// <param name="Purpose">Purpose.</param>
        
        
        
        /// <param name="ExternalContactId">ExternalContactId.</param>
        
        
        
        /// <param name="ExternalOrganizationId">ExternalOrganizationId.</param>
        
        
        
        /// <param name="Sessions">Sessions.</param>
        
        
        public AnalyticsParticipant(string ParticipantId = null, string ParticipantName = null, string UserId = null, PurposeEnum? Purpose = null, string ExternalContactId = null, string ExternalOrganizationId = null, List<AnalyticsSession> Sessions = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ParticipantId = ParticipantId;
            
            
            
            
            
            
            
            
this.ParticipantName = ParticipantName;
            
            
            
            
            
            
            
            
this.UserId = UserId;
            
            
            
            
            
            
            
            
this.Purpose = Purpose;
            
            
            
            
            
            
            
            
this.ExternalContactId = ExternalContactId;
            
            
            
            
            
            
            
            
this.ExternalOrganizationId = ExternalOrganizationId;
            
            
            
            
            
            
            
            
this.Sessions = Sessions;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ParticipantId
        /// </summary>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ParticipantName
        /// </summary>
        [DataMember(Name="participantName", EmitDefaultValue=false)]
        public string ParticipantName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalOrganizationId
        /// </summary>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Sessions
        /// </summary>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<AnalyticsSession> Sessions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsParticipant {\n");
            
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnalyticsParticipant);
        }

        /// <summary>
        /// Returns true if AnalyticsParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsParticipant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) &&
                (
                    this.ParticipantName == other.ParticipantName ||
                    this.ParticipantName != null &&
                    this.ParticipantName.Equals(other.ParticipantName)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
                ) &&
                (
                    this.Sessions == other.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(other.Sessions)
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
                
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                
                if (this.ParticipantName != null)
                    hash = hash * 59 + this.ParticipantName.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                
                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();
                
                if (this.Sessions != null)
                    hash = hash * 59 + this.Sessions.GetHashCode();
                
                return hash;
            }
        }
    }

}
