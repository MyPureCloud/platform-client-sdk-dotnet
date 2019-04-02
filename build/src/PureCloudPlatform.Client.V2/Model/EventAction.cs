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
    /// EventAction
    /// </summary>
    [DataContract]
    public partial class EventAction :  IEquatable<EventAction>
    {
        
        
        
        
        
        /// <summary>
        /// Current state of the action (e.g. qualified, succeeded, errored).
        /// </summary>
        /// <value>Current state of the action (e.g. qualified, succeeded, errored).</value>
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
            /// Enum Missed for "missed"
            /// </summary>
            [EnumMember(Value = "missed")]
            Missed,
            
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
            Offered
        }
        
        
        
        
        /// <summary>
        /// The media type used to deliver the action (e.g. email, webhook).
        /// </summary>
        /// <value>The media type used to deliver the action (e.g. email, webhook).</value>
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
            Webchat
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Current state of the action (e.g. qualified, succeeded, errored).
        /// </summary>
        /// <value>Current state of the action (e.g. qualified, succeeded, errored).</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        /// <summary>
        /// The media type used to deliver the action (e.g. email, webhook).
        /// </summary>
        /// <value>The media type used to deliver the action (e.g. email, webhook).</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventAction" /> class.
        /// </summary>
        /// <param name="Id">ID of the action. (required).</param>
        /// <param name="State">Current state of the action (e.g. qualified, succeeded, errored)..</param>
        /// <param name="MediaType">The media type used to deliver the action (e.g. email, webhook)..</param>
        /// <param name="Prompt">Prompt of the action to be displayed/sent to the visitor..</param>
        /// <param name="CreatedDate">Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public EventAction(string Id = null, StateEnum? State = null, MediaTypeEnum? MediaType = null, string Prompt = null, DateTime? CreatedDate = null)
        {
            this.Id = Id;
            this.State = State;
            this.MediaType = MediaType;
            this.Prompt = Prompt;
            this.CreatedDate = CreatedDate;
            
        }
        
        
        
        /// <summary>
        /// ID of the action.
        /// </summary>
        /// <value>ID of the action.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Prompt of the action to be displayed/sent to the visitor.
        /// </summary>
        /// <value>Prompt of the action to be displayed/sent to the visitor.</value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventAction {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
            return this.Equals(obj as EventAction);
        }

        /// <summary>
        /// Returns true if EventAction instances are equal
        /// </summary>
        /// <param name="other">Instance of EventAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventAction other)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
