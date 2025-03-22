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
    /// ConversationSummaryTopicConversationSummaryParticipant
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTopicConversationSummaryParticipant :  IEquatable<ConversationSummaryTopicConversationSummaryParticipant>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum Acd for "ACD"
            /// </summary>
            [EnumMember(Value = "ACD")]
            Acd,
            
            /// <summary>
            /// Enum Agent for "AGENT"
            /// </summary>
            [EnumMember(Value = "AGENT")]
            Agent,
            
            /// <summary>
            /// Enum Customer for "CUSTOMER"
            /// </summary>
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow
        }
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTopicConversationSummaryParticipant" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Purpose">Purpose.</param>
        public ConversationSummaryTopicConversationSummaryParticipant(string UserId = null, PurposeEnum? Purpose = null)
        {
            this.UserId = UserId;
            this.Purpose = Purpose;
            
        }
        


        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryTopicConversationSummaryParticipant {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
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
            return this.Equals(obj as ConversationSummaryTopicConversationSummaryParticipant);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTopicConversationSummaryParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTopicConversationSummaryParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTopicConversationSummaryParticipant other)
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
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
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

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                return hash;
            }
        }
    }

}
