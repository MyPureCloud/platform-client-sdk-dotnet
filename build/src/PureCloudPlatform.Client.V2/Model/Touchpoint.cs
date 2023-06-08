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
    /// Touchpoint
    /// </summary>
    [DataContract]
    public partial class Touchpoint :  IEquatable<Touchpoint>
    {
        /// <summary>
        /// Media Type of the touchpoint; allowed values are Email, Message and Voice.
        /// </summary>
        /// <value>Media Type of the touchpoint; allowed values are Email, Message and Voice.</value>
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
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// Media Type of the touchpoint; allowed values are Email, Message and Voice.
        /// </summary>
        /// <value>Media Type of the touchpoint; allowed values are Email, Message and Voice.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Touchpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Touchpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Touchpoint" /> class.
        /// </summary>
        /// <param name="ConversationId">ID of conversation..</param>
        /// <param name="AgentId">ID of agent. (required).</param>
        /// <param name="AssociatedValue">The value attributed to this touchpoint. (required).</param>
        /// <param name="MediaType">Media Type of the touchpoint; allowed values are Email, Message and Voice..</param>
        /// <param name="CreatedDate">Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public Touchpoint(string ConversationId = null, string AgentId = null, double? AssociatedValue = null, MediaTypeEnum? MediaType = null, DateTime? CreatedDate = null)
        {
            this.ConversationId = ConversationId;
            this.AgentId = AgentId;
            this.AssociatedValue = AssociatedValue;
            this.MediaType = MediaType;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// ID of conversation.
        /// </summary>
        /// <value>ID of conversation.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// ID of agent.
        /// </summary>
        /// <value>ID of agent.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The value attributed to this touchpoint.
        /// </summary>
        /// <value>The value attributed to this touchpoint.</value>
        [DataMember(Name="associatedValue", EmitDefaultValue=false)]
        public double? AssociatedValue { get; set; }





        /// <summary>
        /// Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Touchpoint {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(obj as Touchpoint);
        }

        /// <summary>
        /// Returns true if Touchpoint instances are equal
        /// </summary>
        /// <param name="other">Instance of Touchpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Touchpoint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.AssociatedValue == other.AssociatedValue ||
                    this.AssociatedValue != null &&
                    this.AssociatedValue.Equals(other.AssociatedValue)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.AssociatedValue != null)
                    hash = hash * 59 + this.AssociatedValue.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
