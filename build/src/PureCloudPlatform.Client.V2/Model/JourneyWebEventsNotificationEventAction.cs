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
    /// JourneyWebEventsNotificationEventAction
    /// </summary>
    [DataContract]
    public partial class JourneyWebEventsNotificationEventAction :  IEquatable<JourneyWebEventsNotificationEventAction>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Rejected for "rejected"
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Timedout for "timedout"
            /// </summary>
            [EnumMember(Value = "timedout")]
            Timedout,
            
            /// <summary>
            /// Enum Errored for "errored"
            /// </summary>
            [EnumMember(Value = "errored")]
            Errored,
            
            /// <summary>
            /// Enum Ignored for "ignored"
            /// </summary>
            [EnumMember(Value = "ignored")]
            Ignored,
            
            /// <summary>
            /// Enum Qualified for "qualified"
            /// </summary>
            [EnumMember(Value = "qualified")]
            Qualified,
            
            /// <summary>
            /// Enum Offered for "offered"
            /// </summary>
            [EnumMember(Value = "offered")]
            Offered,
            
            /// <summary>
            /// Enum Started for "started"
            /// </summary>
            [EnumMember(Value = "started")]
            Started,
            
            /// <summary>
            /// Enum Engaged for "engaged"
            /// </summary>
            [EnumMember(Value = "engaged")]
            Engaged,
            
            /// <summary>
            /// Enum Qualifiedoutsideschedule for "qualifiedOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "qualifiedOutsideSchedule")]
            Qualifiedoutsideschedule,
            
            /// <summary>
            /// Enum Offeredoutsideschedule for "offeredOutsideSchedule"
            /// </summary>
            [EnumMember(Value = "offeredOutsideSchedule")]
            Offeredoutsideschedule,
            
            /// <summary>
            /// Enum Abandoned for "abandoned"
            /// </summary>
            [EnumMember(Value = "abandoned")]
            Abandoned,
            
            /// <summary>
            /// Enum Completed for "completed"
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed,
            
            /// <summary>
            /// Enum Frequencycapreached for "frequencyCapReached"
            /// </summary>
            [EnumMember(Value = "frequencyCapReached")]
            Frequencycapreached
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat,
            
            /// <summary>
            /// Enum Webmessagingoffer for "webMessagingOffer"
            /// </summary>
            [EnumMember(Value = "webMessagingOffer")]
            Webmessagingoffer,
            
            /// <summary>
            /// Enum Contentoffer for "contentOffer"
            /// </summary>
            [EnumMember(Value = "contentOffer")]
            Contentoffer,
            
            /// <summary>
            /// Enum Architectflow for "architectFlow"
            /// </summary>
            [EnumMember(Value = "architectFlow")]
            Architectflow
        }
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationEventAction" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="State">State.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Prompt">Prompt.</param>
        public JourneyWebEventsNotificationEventAction(string Id = null, DateTime? CreatedDate = null, StateEnum? State = null, MediaTypeEnum? MediaType = null, string Prompt = null)
        {
            this.Id = Id;
            this.CreatedDate = CreatedDate;
            this.State = State;
            this.MediaType = MediaType;
            this.Prompt = Prompt;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyWebEventsNotificationEventAction {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
            return this.Equals(obj as JourneyWebEventsNotificationEventAction);
        }

        /// <summary>
        /// Returns true if JourneyWebEventsNotificationEventAction instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebEventsNotificationEventAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebEventsNotificationEventAction other)
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
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
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
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                
                return hash;
            }
        }
    }

}
