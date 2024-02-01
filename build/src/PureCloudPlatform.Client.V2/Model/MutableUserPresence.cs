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
    /// MutableUserPresence
    /// </summary>
    [DataContract]
    public partial class MutableUserPresence :  IEquatable<MutableUserPresence>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutableUserPresence" /> class.
        /// </summary>
        /// <param name="Id">The user's id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Source">Deprecated - The sourceID field should be used as a replacement..</param>
        /// <param name="SourceId">Represents the ID of a registered source.</param>
        /// <param name="Primary">A boolean used to tell whether or not to set this presence source as the primary on a PATCH.</param>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="Message">Message.</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public MutableUserPresence(string Id = null, string Name = null, string Source = null, string SourceId = null, bool? Primary = null, PresenceDefinition PresenceDefinition = null, string Message = null, DateTime? ModifiedDate = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Source = Source;
            this.SourceId = SourceId;
            this.Primary = Primary;
            this.PresenceDefinition = PresenceDefinition;
            this.Message = Message;
            this.ModifiedDate = ModifiedDate;
            
        }
        


        /// <summary>
        /// The user's id
        /// </summary>
        /// <value>The user's id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Deprecated - The sourceID field should be used as a replacement.
        /// </summary>
        /// <value>Deprecated - The sourceID field should be used as a replacement.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Represents the ID of a registered source
        /// </summary>
        /// <value>Represents the ID of a registered source</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }



        /// <summary>
        /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
        /// </summary>
        /// <value>A boolean used to tell whether or not to set this presence source as the primary on a PATCH</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }



        /// <summary>
        /// Gets or Sets PresenceDefinition
        /// </summary>
        [DataMember(Name="presenceDefinition", EmitDefaultValue=false)]
        public PresenceDefinition PresenceDefinition { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MutableUserPresence {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as MutableUserPresence);
        }

        /// <summary>
        /// Returns true if MutableUserPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of MutableUserPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutableUserPresence other)
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
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
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
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();

                if (this.PresenceDefinition != null)
                    hash = hash * 59 + this.PresenceDefinition.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
