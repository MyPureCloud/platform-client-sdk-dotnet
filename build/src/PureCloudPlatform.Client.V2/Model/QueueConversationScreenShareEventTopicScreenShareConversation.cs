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
    /// QueueConversationScreenShareEventTopicScreenShareConversation
    /// </summary>
    [DataContract]
    public partial class QueueConversationScreenShareEventTopicScreenShareConversation :  IEquatable<QueueConversationScreenShareEventTopicScreenShareConversation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationScreenShareEventTopicScreenShareConversation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="OtherMediaUris">OtherMediaUris.</param>
        /// <param name="Address">Address.</param>
        /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
        public QueueConversationScreenShareEventTopicScreenShareConversation(string Id = null, string Name = null, List<QueueConversationScreenShareEventTopicScreenShareMediaParticipant> Participants = null, List<string> OtherMediaUris = null, string Address = null, string UtilizationLabelId = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Participants = Participants;
            this.OtherMediaUris = OtherMediaUris;
            this.Address = Address;
            this.UtilizationLabelId = UtilizationLabelId;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<QueueConversationScreenShareEventTopicScreenShareMediaParticipant> Participants { get; set; }



        /// <summary>
        /// Gets or Sets OtherMediaUris
        /// </summary>
        [DataMember(Name="otherMediaUris", EmitDefaultValue=false)]
        public List<string> OtherMediaUris { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// Gets or Sets UtilizationLabelId
        /// </summary>
        [DataMember(Name="utilizationLabelId", EmitDefaultValue=false)]
        public string UtilizationLabelId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationScreenShareEventTopicScreenShareConversation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
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
            return this.Equals(obj as QueueConversationScreenShareEventTopicScreenShareConversation);
        }

        /// <summary>
        /// Returns true if QueueConversationScreenShareEventTopicScreenShareConversation instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationScreenShareEventTopicScreenShareConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationScreenShareEventTopicScreenShareConversation other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) &&
                (
                    this.OtherMediaUris == other.OtherMediaUris ||
                    this.OtherMediaUris != null &&
                    this.OtherMediaUris.SequenceEqual(other.OtherMediaUris)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.UtilizationLabelId == other.UtilizationLabelId ||
                    this.UtilizationLabelId != null &&
                    this.UtilizationLabelId.Equals(other.UtilizationLabelId)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();

                if (this.OtherMediaUris != null)
                    hash = hash * 59 + this.OtherMediaUris.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.UtilizationLabelId != null)
                    hash = hash * 59 + this.UtilizationLabelId.GetHashCode();

                return hash;
            }
        }
    }

}
