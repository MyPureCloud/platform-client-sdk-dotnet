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
    /// KnowledgeConversationTurn
    /// </summary>
    [DataContract]
    public partial class KnowledgeConversationTurn :  IEquatable<KnowledgeConversationTurn>
    {
        /// <summary>
        /// The participant type.
        /// </summary>
        /// <value>The participant type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External,
            
            /// <summary>
            /// Enum Internal for "Internal"
            /// </summary>
            [EnumMember(Value = "Internal")]
            Internal
        }
        /// <summary>
        /// The participant type.
        /// </summary>
        /// <value>The participant type.</value>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public ParticipantEnum? Participant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeConversationTurn" /> class.
        /// </summary>
        /// <param name="Participant">The participant type..</param>
        /// <param name="Text">The message text..</param>
        public KnowledgeConversationTurn(ParticipantEnum? Participant = null, string Text = null)
        {
            this.Participant = Participant;
            this.Text = Text;
            
        }
        




        /// <summary>
        /// The message text.
        /// </summary>
        /// <value>The message text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeConversationTurn {\n");

            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as KnowledgeConversationTurn);
        }

        /// <summary>
        /// Returns true if KnowledgeConversationTurn instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeConversationTurn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeConversationTurn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Participant == other.Participant ||
                    this.Participant != null &&
                    this.Participant.Equals(other.Participant)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Participant != null)
                    hash = hash * 59 + this.Participant.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                return hash;
            }
        }
    }

}
