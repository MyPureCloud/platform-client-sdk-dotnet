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
    /// RoomUpdateRequest
    /// </summary>
    [DataContract]
    public partial class RoomUpdateRequest :  IEquatable<RoomUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomUpdateRequest" /> class.
        /// </summary>
        /// <param name="Description">Room&#39;s description.</param>
        /// <param name="Subject">Room&#39;s subject.</param>
        /// <param name="PinnedMessageIds">Room&#39;s pinned messages.</param>
        /// <param name="OwnerIds">Room&#39;s owners.</param>
        public RoomUpdateRequest(string Description = null, string Subject = null, List<string> PinnedMessageIds = null, List<string> OwnerIds = null)
        {
            this.Description = Description;
            this.Subject = Subject;
            this.PinnedMessageIds = PinnedMessageIds;
            this.OwnerIds = OwnerIds;
            
        }
        


        /// <summary>
        /// Room&#39;s description
        /// </summary>
        /// <value>Room&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Room&#39;s subject
        /// </summary>
        /// <value>Room&#39;s subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// Room&#39;s pinned messages
        /// </summary>
        /// <value>Room&#39;s pinned messages</value>
        [DataMember(Name="pinnedMessageIds", EmitDefaultValue=false)]
        public List<string> PinnedMessageIds { get; set; }



        /// <summary>
        /// Room&#39;s owners
        /// </summary>
        /// <value>Room&#39;s owners</value>
        [DataMember(Name="ownerIds", EmitDefaultValue=false)]
        public List<string> OwnerIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomUpdateRequest {\n");

            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PinnedMessageIds: ").Append(PinnedMessageIds).Append("\n");
            sb.Append("  OwnerIds: ").Append(OwnerIds).Append("\n");
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
            return this.Equals(obj as RoomUpdateRequest);
        }

        /// <summary>
        /// Returns true if RoomUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.PinnedMessageIds == other.PinnedMessageIds ||
                    this.PinnedMessageIds != null &&
                    this.PinnedMessageIds.SequenceEqual(other.PinnedMessageIds)
                ) &&
                (
                    this.OwnerIds == other.OwnerIds ||
                    this.OwnerIds != null &&
                    this.OwnerIds.SequenceEqual(other.OwnerIds)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.PinnedMessageIds != null)
                    hash = hash * 59 + this.PinnedMessageIds.GetHashCode();

                if (this.OwnerIds != null)
                    hash = hash * 59 + this.OwnerIds.GetHashCode();

                return hash;
            }
        }
    }

}
